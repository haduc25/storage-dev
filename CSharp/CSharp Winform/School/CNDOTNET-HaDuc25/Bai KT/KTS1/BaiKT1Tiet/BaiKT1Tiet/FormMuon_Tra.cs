using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiKT1Tiet
{
    public partial class FormMuon_Tra : Form
    {
        public FormMuon_Tra()
        {
            InitializeComponent();
            connectSQL();
            SqlDataAdapter sqlData = new SqlDataAdapter("select *from MUON_TRA", sqlCon);
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

        private void button3_Click(object sender, EventArgs e)
        {
            connectSQL();
            if (tbMaSach.Text == "" && tbMaDG.Text == "" && tbNM.Text == "" && tbNHT.Text == "" && tbTenTG.Text == "" && tbSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !", "Thông báo");
            }
            else
            {
                sqlCmd = new SqlCommand("insert into MUON_TRA values('" + tbMaSach.Text + "','" + int.Parse(tbMaDG.Text) + "','" + int.Parse(tbNM.Text) + "','" + int.Parse(tbNHT.Text) + "','" + tbTenTG.Text + "','" + int.Parse(tbSL.Text) + "')", sqlCon);
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

        private void btUpdate_Click(object sender, EventArgs e)
        {
            connectSQL();
            sqlCmd = new SqlCommand("Update MUON_TRA set TenSach=@TenSach, NgayMuon=@NgayMuon, NgayHenTra=@NgayHenTra, TenTG=@TenTG, SL=@SL where MaSach=@MaSach", sqlCon);
            sqlCmd.Parameters.AddWithValue("@MaSach", tbMaSach.Text);
            sqlCmd.Parameters.AddWithValue("@MaDG", tbMaDG.Text);
            sqlCmd.Parameters.AddWithValue("@NgayMuon", int.Parse(tbNM.Text));
            sqlCmd.Parameters.AddWithValue("@NgayHenTra", int.Parse(tbNHT.Text));
            sqlCmd.Parameters.AddWithValue("@TenTG", tbTenTG.Text);
            sqlCmd.Parameters.AddWithValue("@SL", int.Parse(tbSL.Text));
            sqlCmd.ExecuteNonQuery();
            //update
            SqlDataAdapter SQLdataA = new SqlDataAdapter("select *from MUON_TRA", sqlCon);
            DataTable dataTable = new DataTable();
            SQLdataA.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            MessageBox.Show("Cập nhập dữ liệu vào CSDL thành công !", "Thông báo");
            sqlCon.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            connectSQL();
            sqlCmd = new SqlCommand("select * from MUON_TRA where MaSach=@MaSach", sqlCon);
            SqlDataAdapter SQLdataA = new SqlDataAdapter(sqlCmd);
            sqlCmd.Parameters.AddWithValue("@MaSach", tbMaSach.Text);
            DataTable dataTable = new DataTable();
            SQLdataA.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlCon.Close();
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
    }
}
