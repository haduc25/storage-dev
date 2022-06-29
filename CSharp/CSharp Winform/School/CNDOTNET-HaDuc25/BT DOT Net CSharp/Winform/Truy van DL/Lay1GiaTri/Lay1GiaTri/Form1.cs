using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lay1GiaTri
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=HADUC25;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection sqlCon = null;
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btQue_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Connected !", "Message");
                }

                //Đối tượng thực thi truy vấn
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select count(*) from SACH";

                //gui query vào connect
                sqlCmd.Connection = sqlCon;

                //result
                int soLuong = (int)sqlCmd.ExecuteScalar();

                MessageBox.Show("")

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDis_Click(object sender, EventArgs e)
        {
            if(sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Disconnected !", "Message");
            }
            else
            {
                MessageBox.Show("You need connect to Sql Server.", "Message");
            }
        }
    }
}
