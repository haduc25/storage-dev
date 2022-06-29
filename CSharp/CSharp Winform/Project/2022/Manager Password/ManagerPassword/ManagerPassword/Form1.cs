using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ManagerPassword
{
    //Created by HaDuc25
    public partial class FormManagerProtectYourPassword : Form
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int BlockSize = 128;

        //private string jinx = String.Empty; //check click dgv

        public FormManagerProtectYourPassword()
        {
            InitializeComponent();
            connect();
            comboBox1.SelectedIndex = 0;
            //form default size ="1200, 620"
        }

        string strCon = @"server=localhost;userid=root;password=;database=manager_pwd;convert zero datetime=True";
        MySqlConnection sqlCon = null;
        MySqlDataAdapter sqlAdapter;
        MySqlCommand sqlCmd;
        DataTable dataTable;

        #region Connect, Disconnect
        void connect()
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new MySqlConnection(strCon);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    //neu ket noi -> moi update
                    updateDataSQL();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng kết nối đến csdl\n" + ex.Message, "Thông báo");

            }
        }

        void disconnect()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Đã ngắt kết nối!");
            }
            else
            {
                MessageBox.Show("Chưa kết nối đến SQL Servel, vui lòng kết nối lại !", "Thông báo");
            }
        }
        #endregion



        void updateDataSQL()
        {
            try
            {
                sqlAdapter = new MySqlDataAdapter("select * from pwd_protected", sqlCon);
                dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng kết nối đến csdl\n" + ex.Message, "Thông báo");
                throw;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            connect();
            check_empty();

        }


        private string passcode = "PrivateBro!";
        private string when_encode;
        private string when_decode;
        private string checker = "none";

        void mahoa1()
        {
            err.Clear();
            try
            {
                //if (tb_pass.Text == "") return;
                byte[] bytes = Encoding.Unicode.GetBytes(txtPwd.Text);
                //Encrypt
                SymmetricAlgorithm crypt = Aes.Create();
                HashAlgorithm hash = MD5.Create();
                crypt.BlockSize = BlockSize;
                crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(passcode));
                crypt.IV = IV;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream =
                       new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(bytes, 0, bytes.Length);
                    }

                    when_encode = Convert.ToBase64String(memoryStream.ToArray());
                    //MessageBox.Show(when_encode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void insert()
        {
            try
            {
                int id = int.Parse(txtID.Text.Trim());
                string mxh = txtSM.Text.Trim();
                string users = txtUser.Text.Trim();
                //string pwd = txtPwd.Text.Trim();
                string pwd = when_encode;
                string email = txtEmail.Text.Trim();
                string sdt = txtSdt.Text.Trim();
                string note = txtNote.Text.Trim();
                DateTime time_now = DateTime.Now;
                DateTime time_update = DateTime.Now;


                sqlCmd = new MySqlCommand("insert into pwd_protected values('" + id + "','" + mxh + "','" + users + "','" + pwd + "','" + email + "','" + sdt + "','" + note + "' ,'" + time_now.ToString("yyyy/MM/dd hh:mm:ss") + "','" + time_update.ToString("yyyy/MM/dd hh:mm:ss") + "')", sqlCon);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Nhập dữ liệu vào CSDL thành công !", "Thông báo");
                updateDataSQL();
                resetDL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgwRow = dataGridView1.Rows[e.RowIndex];
                txtID.Text = dgwRow.Cells[0].Value.ToString();
                txtSM.Text = dgwRow.Cells[1].Value.ToString();
                txtUser.Text = dgwRow.Cells[2].Value.ToString();
                txtPwd.Text = dgwRow.Cells[3].Value.ToString();
                txtEmail.Text = dgwRow.Cells[4].Value.ToString();
                txtSdt.Text = dgwRow.Cells[5].Value.ToString();
                txtNote.Text = dgwRow.Cells[6].Value.ToString();
                lbCreated.Text = "Created: " + dgwRow.Cells[7].Value.ToString();
                lbUpdated.Text = "Updated: " + dgwRow.Cells[8].Value.ToString();
                ////check click
                //jinx = "saw_u_clicked";
                checker = "got_it";
                copy_hihi();
            }
        }
        void check_empty()
        {
            if (string.IsNullOrEmpty(txtID.Text)) //them kt neu id = id tren csdl thi + them 1
            {
                /*lay ra max id tren csdl roi + 1*/
                sqlCmd = new MySqlCommand("select Max(id) from pwd_protected", sqlCon); //lay id max + 1

                string returnedValue = sqlCmd.ExecuteScalar().ToString();

                if (returnedValue != null)
                {
                    int temp_max_id = int.Parse(returnedValue);
                    int max_id = temp_max_id + 1;
                    txtID.Text = max_id.ToString();
                }

                /*tinh theo bang datagribview (nhung se bi loi neu xoa du lieu id o giua)*/
                //int max_row_id = dataGridView1.Rows.Count;
                //txtID.Text = max_row_id.ToString();
            }

            //email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Text = "None"; //tu dong set la None
            }

            //sdt
            if (string.IsNullOrEmpty(txtSdt.Text))
            {
                txtSdt.Text = "None"; //tu dong set la None
            }

            //note
            if (string.IsNullOrEmpty(txtNote.Text))
            {
                txtNote.Text = "Nothing!"; //tu dong set la Nothing
            }


            //user & pwd

            if (!string.IsNullOrEmpty(txtSM.Text) && !string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPwd.Text))
            {
                mahoa1();
                insert();
            }
            else
            {
                err.SetError(txtSM, "Loi !, Vui long nhap dl vao MXH.");
                err.SetError(txtUser, "Loi !, Vui long nhap dl vao Users.");
                err.SetError(txtPwd, "Loi !, Vui long nhap dl vao Password.");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            resetDL();
            updateDataSQL();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    err.SetError(txtSearch, "error pls enter value !");
                }
                else
                {
                    err.Clear();

                    check_selection();


                    try
                    {
                        connect();
                        sqlCmd = new MySqlCommand("select * from pwd_protected where " + value_search + "= @timkiem", sqlCon);
                        sqlCmd.Parameters.AddWithValue("@timkiem", txtSearch.Text.Trim());
                        //
                        sqlAdapter = new MySqlDataAdapter(sqlCmd);
                        dataTable = new DataTable();
                        sqlAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                        if (dataGridView1.Rows.Count < 2)
                        {
                            MessageBox.Show("khong co ket qua cho " + txtSearch.Text.Trim() + "\n vui long thu lai!", "Message");
                        }
                        sqlCon.Close();
                        txtSearch.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
        }


        string value_search = String.Empty; //set empty
        void check_selection()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    value_search = "id";
                    break;
                case 1:
                    value_search = "social_media";
                    break;
                case 2:
                    value_search = "users";
                    break;
                case 3:
                    value_search = "pwd";
                    break;
                case 4:
                    value_search = "email";
                    break;
                case 5:
                    value_search = "note";
                    break;
                default:
                    MessageBox.Show("Some error there!");
                    break;


                    /*slution 2*/
                    /*
                        //if (comboBox1.SelectedIndex == 0)
                        //    MessageBox.Show("index = 0");
                        //else if(comboBox1.SelectedIndex == 1)
                        //    MessageBox.Show("index = 1");
                        //else if (comboBox1.SelectedIndex == 2)
                        //    MessageBox.Show("index = 2");
                        //else if (comboBox1.SelectedIndex == 3)
                        //    MessageBox.Show("index = 3");
                        //else if (comboBox1.SelectedIndex == 4)
                        //    MessageBox.Show("index = 4");
                        //else
                        //    MessageBox.Show("index = 5");
                    */
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            MessageBox.Show(today.ToString("yyyy/MM/dd hh:mm:ss"));
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Randcode(8);
        }

        void Randcode(int Hello)
        {
            Random rand = new Random();
            char[] letters = @"qwertyuioplkjhgfdsazxcvbnQmMNBVCXZASDFGHJKLPOIUYTREW0123456789!#$%&".ToArray();
            string output = null;
            for (int i = 0; i < Hello; i++)
            {
                output += letters[rand.Next(0, letters.Length)];
            }
            txtPwd.Text = output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPwd.Text))
                Clipboard.SetText(txtPwd.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtPwd.PasswordChar == '#' && txtDePwd.PasswordChar == '#')
            {
                txtPwd.PasswordChar = '\0';
                txtDePwd.PasswordChar = '\0';
                btnShowHide.Text = "An";
            }
            else
            {
                txtPwd.PasswordChar = '#';
                txtDePwd.PasswordChar = '#';
                btnShowHide.Text = "Hien";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPwd.Text))
            {
                //if(on)=>off, if(off)=> on
                txtDePwd.Visible = !txtDePwd.Visible;
                btnValidate.Visible = !btnValidate.Visible;

            }
            else { err.SetError(txtPwd, "Loi !, Vui long nhap dl vao Password."); }
        }

        void de_pwd()
        {
            try
            {
                //if (tb_pass.Text == "") return;
                //Decrypt
                byte[] bytes = Convert.FromBase64String(txtPwd.Text);
                SymmetricAlgorithm crypt = Aes.Create();
                HashAlgorithm hash = MD5.Create();
                crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(passcode));
                crypt.IV = IV;

                using (MemoryStream memoryStream = new MemoryStream(bytes))
                {
                    using (CryptoStream cryptoStream =
                       new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        byte[] decryptedBytes = new byte[bytes.Length];
                        cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                        when_decode = Encoding.Unicode.GetString(decryptedBytes);

                        //MessageBox.Show(when_decode);
                        txtPwd.Text = when_decode;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text))
                Clipboard.SetText(txtUser.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
                Clipboard.SetText(txtEmail.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rs == DialogResult.Yes)
                {
                    connect();
                    sqlCmd = new MySqlCommand("Delete from pwd_protected where id=@id_sys", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@id_sys", txtID.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Xoa dl thanh cong !", "Message");

                    updateDataSQL();
                    resetDL();
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void resetDL()
        {
            txtID.Clear();
            txtSM.Clear();
            txtUser.Clear();
            txtPwd.Clear();
            txtEmail.Clear();
            txtNote.Clear();
            txtSearch.Clear();
            txtSdt.Clear();
            txtDePwd.Visible = false;
            txtDePwd.Clear();
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            btnInsert.Enabled = true;
            btnValidate.Enabled = true;
            btnValidate.Visible = false;
            txtSM.Focus();
            txtEnPass.Clear();
            txtDePass.Clear();
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
            btnDePwd.Enabled = true;
            btnRandom.Enabled = true;

            txtSM.ReadOnly = false;
            txtUser.ReadOnly = false;
            txtPwd.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSdt.ReadOnly = false;
            txtNote.ReadOnly = false;

            Clipboard.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult rs = MessageBox.Show("Dữ liệu sẽ thay đổi, bạn có chắc chắn muốn sửa không ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rs == DialogResult.Yes)
                {

                    txtNote.AppendText(Environment.NewLine); //thay cho \n
                    txtNote.AppendText(Environment.NewLine); //thay cho \n
                    txtNote.Text += "#===Log_[" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "]====#";
                    txtNote.AppendText(Environment.NewLine); //thay cho \n

                    //id
                    if (!String.IsNullOrEmpty(txtNote.Text))
                    {
                        txtNote.Text += old_id;
                        txtNote.AppendText(Environment.NewLine); //thay cho \n
                    }


                    //mxh
                    if (!String.IsNullOrEmpty(txtNote.Text))
                    {
                        txtNote.Text += old_mxh;
                        txtNote.AppendText(Environment.NewLine); //thay cho \n
                    }

                    //user
                    if (!String.IsNullOrEmpty(txtNote.Text))
                    {
                        txtNote.Text += old_user;
                        txtNote.AppendText(Environment.NewLine); //thay cho \n
                    }

                    //pwd
                    if (!String.IsNullOrEmpty(txtNote.Text))
                    {
                        txtNote.Text += old_pwd;
                        txtNote.AppendText(Environment.NewLine); //thay cho \n
                    }

                    //email
                    if (!String.IsNullOrEmpty(txtNote.Text))
                    {
                        txtNote.Text += old_email;
                        txtNote.AppendText(Environment.NewLine); //thay cho \n
                    }

                    //sdt
                    if (!String.IsNullOrEmpty(txtNote.Text))
                    {
                        txtNote.Text += old_sdt;
                        txtNote.AppendText(Environment.NewLine); //thay cho \n
                    }

                    //note
                    if (!String.IsNullOrEmpty(txtNote.Text))
                    {
                        txtNote.Text += old_note;
                        txtNote.AppendText(Environment.NewLine); //thay cho \n
                    }

                    //update
                    connect();
                    DateTime time_update = DateTime.Now;

                    sqlCmd = new MySqlCommand("update pwd_protected set social_media=@sm, users=@user_sys, pwd=@pwd_sys, email=@email_sys, sdt=@sdt_sys, note=@note_sys, time_updated=@time_updated_sys where id=@id_sys", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@id_sys", txtID.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@sm", txtSM.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@user_sys", txtUser.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@pwd_sys", txtPwd.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email_sys", txtEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@sdt_sys", txtSdt.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@note_sys", txtNote.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@time_updated_sys", time_update.ToString("yyyy/MM/dd hh:mm:ss"));
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Cap nhap dl thanh cong !", "Message");

                    updateDataSQL();
                    resetDL();
                    sqlCon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            updateDataSQL();
            MessageBox.Show("Lam moi dl thanh cong !", "Message");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                sqlCon.Close();
                Application.Exit();
            }
        }

        //for copy[log]
        private string old_id = String.Empty;
        private string old_mxh = String.Empty;
        private string old_user = String.Empty;
        private string old_pwd = String.Empty;
        private string old_email = String.Empty;
        private string old_sdt = String.Empty;
        private string old_note = String.Empty;

        private void txtSM_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                btnDePwd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDel.Enabled = false;
                btnInsert.Enabled = true;
                btnRandom.Enabled = true;
            }
            else
            {
                btnDePwd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDel.Enabled = true;
                btnInsert.Enabled = false;
                btnRandom.Enabled = false;
                //read only
                txtSM.ReadOnly = true;
                txtUser.ReadOnly = true;
                txtPwd.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtSdt.ReadOnly = true;
                txtNote.ReadOnly = true;
            }
        }

        void copy_hihi()
        {
            try
            {
                //copy

                //id
                if (!string.IsNullOrEmpty(txtID.Text.Trim()))
                {
                    Clipboard.SetText(txtID.Text);
                    old_id = "Old ID: " + Clipboard.GetText();
                }

                //mxh
                if (!string.IsNullOrEmpty(txtSM.Text.Trim()))
                {
                    Clipboard.SetText(txtSM.Text);
                    old_mxh = "Old MXH: " + Clipboard.GetText();
                }

                //user
                if (!string.IsNullOrEmpty(txtUser.Text.Trim()))
                {
                    Clipboard.SetText(txtUser.Text);
                    old_user = "Old User: " + Clipboard.GetText();
                }

                //pwd
                if (!string.IsNullOrEmpty(txtPwd.Text.Trim()))
                {
                    Clipboard.SetText(txtPwd.Text);
                    old_pwd = "Old Pwd: " + Clipboard.GetText();
                }

                //email
                if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    Clipboard.SetText(txtEmail.Text);
                    old_email = "Old E-mail: " + Clipboard.GetText();
                }

                //sdt
                if (!string.IsNullOrEmpty(txtSdt.Text.Trim()))
                {
                    Clipboard.SetText(txtSdt.Text);
                    old_sdt = "Old Sdt: " + Clipboard.GetText();
                }

                //note
                if (!string.IsNullOrEmpty(txtNote.Text.Trim()))
                {
                    Clipboard.SetText(txtNote.Text);
                    old_note = "Old Note: " + Clipboard.GetText();
                }

                //MessageBox.Show(old_id + "\n" + old_mxh + "\n" + old_user + "\n" + old_pwd + "\n" + old_email + "\n" + old_sdt + "\n" + old_note);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDePwd.Text))
            {
                MessageBox.Show("Vui long nhap mat khau", "Message!");
            }
            else if (txtDePwd.Text == passcode)
            {
                de_pwd();
                btnUpdate.Enabled = false;
                btnValidate.Visible = false;
                txtDePwd.Visible = false;
                txtDePwd.Text = null;
                btnDePwd.Enabled = false;
            }
            else { MessageBox.Show("Mat khau ban vua nhap khong chinh xac, vui long thu lai!", "Message!"); }
        }

        private void txtEnPass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!String.IsNullOrEmpty(txtEnPass.Text))
                    {
                        //if (tb_pass.Text == "") return;
                        byte[] bytes = Encoding.Unicode.GetBytes(txtEnPass.Text);
                        //Encrypt
                        SymmetricAlgorithm crypt = Aes.Create();
                        HashAlgorithm hash = MD5.Create();
                        crypt.BlockSize = BlockSize;
                        crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(passcode));
                        crypt.IV = IV;

                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            using (CryptoStream cryptoStream =
                               new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(bytes, 0, bytes.Length);
                            }
                            txtEnPass.Clear();
                            txtEnPass.Text = Convert.ToBase64String(memoryStream.ToArray());
                        }
                    }
                    else { MessageBox.Show("Vui long nhap mat khau de ma hoa!", "Message!"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEnPass.Text))
                Clipboard.SetText(txtEnPass.Text);
        }

        private void txtDePass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (string.IsNullOrEmpty(txtDePwd.Text) && string.IsNullOrEmpty(txtDePass.Text))
                    {
                        MessageBox.Show("Vui long nhap mat khau de ma hoa!", "Message!");
                    }
                    else if (txtDePwd.Text == passcode)
                    {
                        try
                        {
                            //Decrypt
                            byte[] bytes = Convert.FromBase64String(txtDePass.Text);
                            SymmetricAlgorithm crypt = Aes.Create();
                            HashAlgorithm hash = MD5.Create();
                            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(passcode));
                            crypt.IV = IV;

                            using (MemoryStream memoryStream = new MemoryStream(bytes))
                            {
                                using (CryptoStream cryptoStream =
                                   new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                                {
                                    byte[] decryptedBytes = new byte[bytes.Length];
                                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                                    when_decode = Encoding.Unicode.GetString(decryptedBytes);
                                    txtDePass.Text = when_decode;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else { MessageBox.Show("Mat khau ban vua nhap khong chinh xac, vui long thu lai!", "Message!"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDePass.Text))
                Clipboard.SetText(txtDePass.Text);
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            lbPwd.Text = "Mat Khau (" + txtPwd.Text.Length + ")";
        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            txtPwd.ReadOnly = false;
        }

        private void txtSM_Click(object sender, EventArgs e)
        {
            txtSM.ReadOnly = false;
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.ReadOnly = false;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = false;
        }

        private void txtSdt_Click(object sender, EventArgs e)
        {
            txtSdt.ReadOnly = false;
        }

        private void txtNote_Click(object sender, EventArgs e)
        {
            txtNote.ReadOnly = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            MessageBox.Show("Clear successfully !");
        }
    }
}
