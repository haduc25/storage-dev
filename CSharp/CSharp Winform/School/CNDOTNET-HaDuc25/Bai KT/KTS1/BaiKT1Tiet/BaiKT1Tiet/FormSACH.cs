using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiKT1Tiet
{
    public partial class FormSACH : Form
    {
        public FormSACH()
        {
            InitializeComponent();
            connectSQL();
            SqlDataAdapter sqlData = new SqlDataAdapter("select *from SACH", sqlCon);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView1.DataSource = dtbl;    
        }

        string strCon = @"Data Source=HADUC25;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection sqlCon = null;

        //command
        SqlCommand sqlCmd;

        #region Connect
        void connectSQL()
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }

                //Connection
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
        #endregion

        private void btCon_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectSQL();
            SqlDataAdapter sqlData = new SqlDataAdapter("select *from SACH", sqlCon);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Disconnected");
            }
            else
            {
                MessageBox.Show("Chưa kết nối đến SQL Servel, vui lòng kết nối lại !");
            }
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            connectSQL();
            if (tbMaSach.Text == "" && tbTenSach.Text == "" && tbNXB.Text == "" && tbNam.Text == "" && tbTenTG.Text == "" && tbSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !", "Thông báo");
            }
            else
            {
                sqlCmd = new SqlCommand("insert into SACH values('" + tbMaSach.Text + "','" + tbTenSach.Text + "','" + tbNXB.Text + "','" + int.Parse(tbNam.Text) + "','" + tbTenTG.Text + "','" + int.Parse(tbSL.Text) + "')", sqlCon);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Nhập dữ liệu vào CSDL thành công !", "Thông báo");
                //update
                SqlDataAdapter SQLdataA = new SqlDataAdapter("select *from SACH", sqlCon);
                DataTable dataTable = new DataTable();
                SQLdataA.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            sqlCon.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connectSQL();
            sqlCmd = new SqlCommand("Update SACH set TenSach=@TenSach, NXB=@NXB, NamXB=@NamXB, TenTG=@TenTG, SL=@SL where MaSach=@MaSach", sqlCon);
            sqlCmd.Parameters.AddWithValue("@MaSach", tbMaSach.Text);
            sqlCmd.Parameters.AddWithValue("@TenSach", tbTenSach.Text);
            sqlCmd.Parameters.AddWithValue("@NXB", tbNXB.Text);
            sqlCmd.Parameters.AddWithValue("@NamXB", int.Parse(tbNam.Text));
            sqlCmd.Parameters.AddWithValue("@TenTG", tbTenTG.Text);
            sqlCmd.Parameters.AddWithValue("@SL", int.Parse(tbSL.Text));
            sqlCmd.ExecuteNonQuery();
            //update
            SqlDataAdapter SQLdataA = new SqlDataAdapter("select *from SACH", sqlCon);
            DataTable dataTable = new DataTable();
            SQLdataA.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            MessageBox.Show("Cập nhập dữ liệu vào CSDL thành công !", "Thông báo");
            sqlCon.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            connectSQL();
            sqlCmd = new SqlCommand("Delete SACH where MaSach=@MaSach", sqlCon);
            sqlCmd.Parameters.AddWithValue("@MaSach", tbMaSach.Text);
            sqlCmd.ExecuteNonQuery();
            //update
            SqlDataAdapter SQLdataA = new SqlDataAdapter("select *from SACH", sqlCon);
            DataTable dataTable = new DataTable();
            SQLdataA.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            MessageBox.Show("Xóa dữ liệu trong CSDL thành công !", "Thông báo");
            sqlCon.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connectSQL();
            sqlCmd = new SqlCommand("select * from SACH where MaSach=@MaSach", sqlCon);
            SqlDataAdapter SQLdataA = new SqlDataAdapter(sqlCmd);
            sqlCmd.Parameters.AddWithValue("@MaSach", tbMaSach.Text);
            DataTable dataTable = new DataTable();
            SQLdataA.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlCon.Close();
        }

        private void tbSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbTenTG_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbNam_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbNXB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSACH_Load(object sender, EventArgs e)
        {

        }
    }
}
