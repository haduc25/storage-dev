using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTKTTH2
{
    public partial class QueyData : Form
    {
        public QueyData()
        {
            InitializeComponent();
            connectSQL();
            updateDataSQL();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        string strCon = @"Data Source=HADUC25;Initial Catalog=QLKhachSan;Integrated Security=True";
        SqlConnection sqlCon = null;

        //command
        SqlCommand sqlCmd;

        #region Connect, Disconnect
        void connectSQL()
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DisconnectSQL()
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

        #region updateDataSQL, checkInsert, resetValue, updateSQL, searchSQL, checkSearch, checkDel
        void updateDataSQL()
        {
            SqlDataAdapter SQLdataA = new SqlDataAdapter("select *from Phong", sqlCon);
            DataTable dataTable = new DataTable();
            SQLdataA.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        void checkInsert()
        {
            if(txtMaK.Text.Trim() == "" || txtTenK.Text.Trim() == "" || txtTenP.Text.Trim() == "" || txtSDT.Text.Trim() == "" && txtSDT.Text.Trim() == "" || txtDonGia.Text.Trim() == "") 
            {
                if (txtMaK.Text.Trim() == "")
                {
                    err.SetError(txtMaK, "Bạn không để trống mã khách!");
                    return;
                }
                else { err.Clear(); }

                if (txtTenK.Text.Trim() == "")
                {
                    err.SetError(txtTenK, "Bạn không để trống tên khách");
                    return;
                }
                else { err.Clear(); }

                if (txtTenP.Text.Trim() == "")
                {
                    err.SetError(txtTenP, "Bạn không để trống tên phòng!");
                    return;
                }
                else { err.Clear(); }

                if (txtSDT.Text.Trim() == "")
                {
                    err.SetError(txtSDT, "Bạn không để trống số điện thoại!");
                    return;
                }
                else { err.Clear(); }

                if (dtpNgayNhan.Value > dtpNgayTra.Value)
                {
                    err.SetError(dtpNgayNhan, "Ngày nhận phải nhỏ hơn ngày trả!");
                    return;
                }
                else
                {  err.Clear(); }

                if (dtpNgayTra.Value < dtpNgayNhan.Value)
                {
                    err.SetError(dtpNgayTra, "Ngày nhận phải lớn hơn ngày nhận!");
                    return;
                }
                else
                {  err.Clear(); }

                if (txtDonGia.Text.Trim() == "")
                {
                    err.SetError(txtDonGia, "Bạn không để trống đơn giá!");
                    return;
                }
                else { err.Clear(); }
            }
            else { insertSQL(); }
        }

        void checkDel()
        {
                if (txtMaK.Text.Trim() == "")
                {
                    err.SetError(txtMaK, "Bạn không để trống mã khách!");
                    return;
                }
                else 
                {
                    err.Clear();
                    connectSQL();
                    DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (check == DialogResult.Yes)
                    {
                        sqlCmd = new SqlCommand("Delete Phong where MaK=@MaK", sqlCon);
                        sqlCmd.Parameters.AddWithValue("@MaK", txtMaK.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        updateDataSQL();
                        MessageBox.Show("Xóa dữ liệu trong CSDL thành công !", "Thông báo");
                        resetValue();
                        sqlCon.Close();
                    }
                }
        }

        void insertSQL()
        {
            string mak = txtMaK.Text.Trim();
            string tenk = txtTenK.Text.Trim();
            int sdt = int.Parse(txtSDT.Text.Trim());
            string tenp = txtTenP.Text.Trim();
            double dongia = double.Parse(txtDonGia.Text.Trim());

            sqlCmd = new SqlCommand("insert into Phong values('" + mak + "','" + tenk + "','" + sdt + "','" + tenp + "','"+dtpNgayNhan.Value.Date+ "','" + dtpNgayTra.Value.Date + "','" +dongia + "')", sqlCon);
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Nhập dữ liệu vào CSDL thành công !", "Thông báo");
            //update
            updateDataSQL();
            resetValue();
            sqlCon.Close();
        }

        void resetValue()
        {
            txtMaK.Clear();
            txtTenK.Clear();
            txtSDT.Clear();
            txtTenP.Clear();

            dtpNgayNhan.Value = DateTime.Now;
            dtpNgayNhan.Format = DateTimePickerFormat.Short;
            dtpNgayNhan.CustomFormat = "";            
            
            dtpNgayTra.Value = DateTime.Now;
            dtpNgayTra.Format = DateTimePickerFormat.Short;
            dtpNgayTra.CustomFormat = "";

            txtDonGia.Clear();
            txtMaK.Focus();
            err.Clear();
        }

        void updateSQL()
        {
            string mak = txtMaK.Text.Trim();
            string tenk = txtTenK.Text.Trim();
            int sdt = int.Parse(txtSDT.Text.Trim());
            string tenp = txtTenP.Text.Trim();
            double dongia = double.Parse(txtDonGia.Text.Trim());

            sqlCmd = new SqlCommand("Update Phong set TenK=@TenK, SDT=@SDT, TenP=@TenP, NgayNhan=@NgayNhan, NgayTra=@NgayTra, Dongia=@Dongia where MaK=@MaK", sqlCon);
            sqlCmd.Parameters.AddWithValue("@MaK", mak);
            sqlCmd.Parameters.AddWithValue("@TenK", tenk);
            sqlCmd.Parameters.AddWithValue("@SDT", sdt);
            sqlCmd.Parameters.AddWithValue("@TenP", tenp);
            sqlCmd.Parameters.AddWithValue("@NgayNhan", dtpNgayNhan.Text);
            sqlCmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Text);
            sqlCmd.Parameters.AddWithValue("@Dongia", dongia);
            sqlCmd.ExecuteNonQuery();
        }

        void searchSQL()
        {
            sqlCmd = new SqlCommand("select * from Phong where TenK=@TenK", sqlCon);
            SqlDataAdapter SQLdataA = new SqlDataAdapter(sqlCmd);
            sqlCmd.Parameters.AddWithValue("@TenK", txtSearch.Text);
            DataTable dataTable = new DataTable();
            SQLdataA.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlCon.Close();
        }

        void checkSearch()
        {
            if (txtSearch.Text.Trim() == "")
            {
                if (txtSearch.Text.Trim() == "")
                {
                    err.SetError(txtSearch, "Bạn không được để trống tên khách hàng!");
                    return;
                }
                else { err.Clear(); }
            }
            else
            {
                connectSQL();
                searchSQL();
            }

        }

        void checkUpdate()
        {
                if (txtMaK.Text.Trim() == "")
                {
                    err.SetError(txtMaK, "Bạn không để trống mã khách!");
                    return;
                }
                else 
                { 
                    err.Clear(); 
                    connectSQL();
                    DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (check == DialogResult.Yes)
                    {
                        updateSQL();
                        updateDataSQL();
                        MessageBox.Show("Cập nhập dữ liệu vào CSDL thành công !", "Thông báo");
                        sqlCon.Close();
                    }
                }
        }
        #endregion
        private void btnInsert_Click(object sender, EventArgs e)
        {
            checkInsert();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                err.SetError(txtSDT, "Vui lòng nhập số!");
                return;
            }
            else { err.Clear(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkDel();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dgwRow = dataGridView1.Rows[e.RowIndex];
                txtMaK.Text = dgwRow.Cells[0].Value.ToString();
                txtTenK.Text = dgwRow.Cells[1].Value.ToString();
                txtSDT.Text = dgwRow.Cells[2].Value.ToString();
                txtTenP.Text = dgwRow.Cells[3].Value.ToString();
                dtpNgayNhan.Text = dgwRow.Cells[4].Value.ToString();
                dtpNgayTra.Text = dgwRow.Cells[5].Value.ToString();
                txtDonGia.Text = dgwRow.Cells[6].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            checkUpdate();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (check == DialogResult.Yes)
                {
                    this.Close();
                    return true;
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            checkSearch();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            updateDataSQL();
            resetValue();
            MessageBox.Show("Làm mới dữ liệu thành công !", "Thông báo");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
