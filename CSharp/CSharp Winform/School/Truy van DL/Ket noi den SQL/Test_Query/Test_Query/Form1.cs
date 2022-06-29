using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_Query
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ketnoi();
            capnhap();
        }

        string strCon = @"Data Source=HADUC25;Initial Catalog=QLDIEMTHI;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd;

        void ketnoi()
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

        void capnhap()
        {
            SqlDataAdapter SQLdataA = new SqlDataAdapter("select * from MONHOC", sqlCon);
            DataTable dataTable = new DataTable();
            SQLdataA.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maM = txtMaM.Text.Trim();
            string tenM = txtTenM.Text.Trim();
            string sotc = txtSoTC.Text.Trim();

            sqlCmd = new SqlCommand("insert into MONHOC values('" + maM + "','" + tenM + "','" + sotc + "')", sqlCon);
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Nhập dữ liệu vào CSDL thành công !", "Thông báo");
            capnhap();
        }
    }
}
