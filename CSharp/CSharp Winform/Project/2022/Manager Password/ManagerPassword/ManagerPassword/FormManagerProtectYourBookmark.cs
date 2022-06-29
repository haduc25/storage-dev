using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ManagerPassword
{
    //Created by HaDuc25
    public partial class FormManagerProtectYourBookmark : Form
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int BlockSize = 128;

        //private string jinx = String.Empty; //check click dgv

        public FormManagerProtectYourBookmark()
        {
            InitializeComponent();
            connect();
            cbbMXH.SelectedIndex = 0;
            cbbCategories.SelectedIndex = 0;
            cbbStatus.SelectedIndex = 0;
            cbbVisible.SelectedIndex = 0;
            cbbVsb.SelectedIndex = 0;
            cbbSearch.SelectedIndex = 0;
            txtID.Focus();

            

            //var a = cbbCategories.SelectedIndex = (cbbCategories.Items.Count);
            //var a = cbbCategories.Items.Count;
            //MessageBox.Show(a.ToString());


            //cbbCategories.DisplayMember = "Text";
            //cbbCategories.ValueMember = "Value";

            //cbbCategories.Items.Add(new { Text = "report A", Value = 1 });
            //cbbCategories.Items.Add(new { Text = "report B", Value = 2 });
            //cbbCategories.Items.Add(new { Text = "report C", Value = 3 });
            //cbbCategories.Items.Add(new { Text = "report D", Value = 4 });
            //cbbCategories.Items.Add(new { Text = "report E", Value = 5 });

            //cbbCategories.Items.Add(item);
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


                //sqlAdapter = new MySqlDataAdapter("select `visible` from bookmark_protected", sqlCon);
                ////sqlAdapter = new MySqlDataAdapter("select `id`, `categories`, `social_media`, `url`, `note`, `status`, `time_created`, `time_updated` from `bookmark_protected`", sqlCon);

                //dataTable = new DataTable();
                //sqlAdapter.Fill(dataTable);



                sqlAdapter = new MySqlDataAdapter("select `id`, `categories`, `social_media`, `url`, `note`, `status`, `time_created`, `time_updated` from `bookmark_protected` where `visible` = 0", sqlCon);

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
            txtSM.Clear();

        }


        private string passcode = "PrivateBro!";
        private string when_encode;
        private string when_decode;

        void mahoa1()
        {
            err.Clear();
            try
            {
                //if (tb_pass.Text == "") return;
                byte[] bytes = Encoding.Unicode.GetBytes(txtUrl.Text);
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
                string mxh = txtSM.Text.Trim();
                string cate = txtCategories.Text.Trim();
                string url = txtUrl.Text.Trim();
                string note = txtNote.Text.Trim();
                string status = txtStatus.Text.Trim();
                DateTime time_now = DateTime.Now;
                DateTime time_update = DateTime.Now;
                int vsb = cbbVsb.SelectedIndex;


                sqlCmd = new MySqlCommand("insert into bookmark_protected values('" + null + "','" + cate + "','" + mxh + "','" + url + "','" + note + "' ,'" + status + "' ,'" + time_now.ToString("yyyy/MM/dd hh:mm:ss") + "','" + time_update.ToString("yyyy/MM/dd hh:mm:ss") + "','" + vsb +"')", sqlCon);
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
        //cbbCategories.DisplayMember = "Text";
        //cbbCategories.ValueMember = "Value";

        //cbbCategories.Items.Add(new { Text = "report A", Value = 1 });
        //cbbCategories.Items.Add(new { Text = "report B", Value = 2 });
        //cbbCategories.Items.Add(new { Text = "report C", Value = 3 });
        //cbbCategories.Items.Add(new { Text = "report D", Value = 4 });
        //cbbCategories.Items.Add(new { Text = "report E", Value = 5 });
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbCategories.DisplayMember = "Text";
            cbbCategories.ValueMember = "Value";

            if (e.RowIndex != -1)
            {
                DataGridViewRow dgwRow = dataGridView1.Rows[e.RowIndex];
                txtID.Text = dgwRow.Cells[0].Value.ToString();
                txtCategories.Text = dgwRow.Cells[1].Value.ToString();
                txtSM.Text = dgwRow.Cells[2].Value.ToString();
                txtUrl.Text = dgwRow.Cells[3].Value.ToString();
                txtNote.Text = dgwRow.Cells[4].Value.ToString();
                txtStatus.Text = dgwRow.Cells[5].Value.ToString();
                lbCreated.Text = "Created: " + dgwRow.Cells[6].Value.ToString();
                lbUpdated.Text = "Updated: " + dgwRow.Cells[7].Value.ToString();
            }
        }
        void check_empty()
        {
            //note
            if (string.IsNullOrEmpty(txtNote.Text))
            {
                txtNote.Text = "Nothing!"; //tu dong set la Nothing
            }


            //user & pwd

            //if (!string.IsNullOrEmpty(txtSM.Text) && !string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPwd.Text))            
            if (!string.IsNullOrEmpty(txtSM.Text) && !string.IsNullOrEmpty(txtUrl.Text))
            {
                //mahoa1();
                insert();
            }
            else
            {
                err.SetError(txtSM, "Loi !, Vui long nhap dl vao MXH.");
                //err.SetError(txtUser, "Loi !, Vui long nhap dl vao Users.");
                err.SetError(txtUrl, "Loi !, Vui long nhap dl vao Password.");
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

                    //check_selection();


                    try
                    {
                        connect();
                        //$sql = "SELECT * FROM `products` WHERE `name` LIKE '%$str%' OR `price` LIKE '%$str%'";

                        sqlCmd = new MySqlCommand("select * from bookmark_protected where " + value_search + " like @timkiem", sqlCon);
                        //sqlCmd = new MySqlCommand("select * from bookmark_protected where " + value_search + " like @timkiem or note like @timkiem", sqlCon);
                        //sqlCmd = new MySqlCommand("SELECT * FROM bookmark_protected WHERE id LIKE @timkiem OR Social Media LIKE @timkiem OR Users like @timkiem OR E-mail LIKE @timkiem OR Note LIKE @timkiem", sqlCon);                        
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
            switch (cbbSearch.SelectedIndex)
            {
                case 0:
                    value_search = "id";
                    break;
                case 1:
                    value_search = "categories";
                    break;
                case 2:
                    value_search = "social_media";

                    break;
                case 3:
                    value_search = "url";
                    break;
                case 4:
                    value_search = "note";
                    break;
                case 5:
                    value_search = "status";
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
            txtUrl.Text = output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
                Clipboard.SetText(txtUrl.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if (txtPwd.PasswordChar == '#' && txtDePwd.PasswordChar == '#')
            if (txtUrl.PasswordChar == '#')
            {
                txtUrl.PasswordChar = '\0';
                //txtDePwd.PasswordChar = '\0';
                //btnShowHide.Text = "An";
            }
            else
            {
                txtUrl.PasswordChar = '#';
                //txtDePwd.PasswordChar = '#';
                //btnShowHide.Text = "Hien";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
            {
                //if(on)=>off, if(off)=> on
                //txtDePwd.Visible = !txtDePwd.Visible;
                //btnValidate.Visible = !btnValidate.Visible;

            }
            else { err.SetError(txtUrl, "Loi !, Vui long nhap dl vao Password."); }
        }

        void de_pwd()
        {
            try
            {
                //if (tb_pass.Text == "") return;
                //Decrypt
                byte[] bytes = Convert.FromBase64String(txtUrl.Text);
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
                        txtUrl.Text = when_decode;
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
            //if (!string.IsNullOrEmpty(txtUser.Text))
                //Clipboard.SetText(txtUser.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtEmail.Text))
            //    Clipboard.SetText(txtEmail.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rs == DialogResult.Yes)
                {
                    connect();
                    sqlCmd = new MySqlCommand("Delete from bookmark_protected where id=@id_sys", sqlCon);
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

            //txtUser.Clear();
            txtUrl.Clear();
            //txtEmail.Clear();
            txtNote.Clear();
            txtSearch.Clear();
            //txtSdt.Clear();
            //txtDePwd.Visible = false;
            //txtDePwd.Clear();
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            btnInsert.Enabled = true;
            //btnValidate.Enabled = true;
            //btnValidate.Visible = false;

            txtSM.Focus();
            txtEnPass.Clear();
            txtDePass.Clear();
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
            //btnDePwd.Enabled = true;
            //btnRandom.Enabled = true;

            txtSM.ReadOnly = false;
            //txtUser.ReadOnly = false;
            txtUrl.ReadOnly = false;
            //txtEmail.ReadOnly = false;
            //txtSdt.ReadOnly = false;
            txtNote.ReadOnly = false;

            //temp
            //txtSM.Clear(); 
            //Clipboard.Clear();
            //txtCategories.Clear();

        }

        private void button9_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult rs = MessageBox.Show("Dữ liệu sẽ thay đổi, bạn có chắc chắn muốn sửa không ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rs == DialogResult.Yes)
                {
                    //update
                    connect();
                    DateTime time_update = DateTime.Now;

                    sqlCmd = new MySqlCommand("update bookmark_protected set categories=@cate, social_media=@sm, url=@url_sys, note=@note_sys, status=@status_sys, time_updated=@time_updated_sys where id=@id_sys", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@id_sys", txtID.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@cate", txtCategories.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@sm", txtSM.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@url_sys", txtUrl.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@note_sys", txtNote.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@status_sys", txtStatus.Text.Trim());
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
                //btnDePwd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDel.Enabled = false;
                btnInsert.Enabled = true;
            }
            else
            {
                //btnDePwd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDel.Enabled = true;
                btnInsert.Enabled = false;
                //btnRandom.Enabled = false;
                //read only
                //txtUser.ReadOnly = true;
                txtUrl.ReadOnly = true;
                //txtEmail.ReadOnly = true;
                //txtSdt.ReadOnly = true;
                txtNote.ReadOnly = true;
                txtCategories.ReadOnly = true;
            }

            if (txtSM.Text.Trim() == "Other...")
            {
                txtSM.Clear();
                txtSM.Focus();
                txtSM.ReadOnly = false;
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
/*                    if (string.IsNullOrEmpty(txtDePwd.Text) && string.IsNullOrEmpty(txtDePass.Text))
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
                    else { MessageBox.Show("Mat khau ban vua nhap khong chinh xac, vui long thu lai!", "Message!"); }*/
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
            lbUrl.Text = "Url (" + txtUrl.Text.Length + ")";
        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            txtUrl.ReadOnly = false;
        }

        private void txtSM_Click(object sender, EventArgs e)
        {
            txtSM.ReadOnly = false;
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            //txtUser.ReadOnly = false;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            //txtEmail.ReadOnly = false;
        }

        private void txtSdt_Click(object sender, EventArgs e)
        {
            //txtSdt.ReadOnly = false;
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

        private void cbbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCategories.Text = cbbCategories.Text;
        }

        private void txtCategories_TextChanged(object sender, EventArgs e)
        {
            if(txtCategories.Text.Trim() == "Other...")
            {
                txtCategories.Clear();
                txtCategories.Focus();
                txtCategories.ReadOnly = false;

            }
        }

        private void txtCategories_Click(object sender, EventArgs e)
        {
            txtCategories.ReadOnly = false;
        }

        private void cbbMXH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSM.Text = cbbMXH.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStatus.Text = cbbStatus.Text;
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            if (txtStatus.Text.Trim() == "Other...")
            {
                txtStatus.Clear();
                txtStatus.Focus();
                txtStatus.ReadOnly = false;

            }
        }

        private void txtStatus_Click(object sender, EventArgs e)
        {
            txtStatus.ReadOnly = false;
        }

        private void txtSM_Leave(object sender, EventArgs e)
        {
            if (txtSM.Text.Length <= 0) return;
            string text = txtSM.Text.Trim();
            string s = text.Substring(0, 1).ToUpper() + text.Substring(1);

            txtSM.Text = s;
        }

        private void txtNote_Leave(object sender, EventArgs e)
        {
            if (txtNote.Text.Length <= 0) return;
            string text = txtNote.Text.Trim();
            string txtUpper = text.Substring(0, 1).ToUpper() + text.Substring(1);

            txtNote.Text = txtUpper;
        }



        private void cbbVisible_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? value_visible = 0;

            switch (cbbVisible.SelectedIndex)
            {
                case 0:
                    value_visible = 0;
                    break;
                case 1:
                    value_visible = 1;
                    break;
                default:
                    MessageBox.Show("Some error there!");
                    break;
            }

            try
            {
                connect();
                sqlCmd = new MySqlCommand("select `id`, `categories`, `social_media`, `url`, `note`, `status`, `time_created`, `time_updated` from bookmark_protected where `visible` =" + value_visible, sqlCon);
                sqlAdapter = new MySqlDataAdapter(sqlCmd);
                dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                sqlCon.Close();
                txtSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_selection();
        }
    }
}
