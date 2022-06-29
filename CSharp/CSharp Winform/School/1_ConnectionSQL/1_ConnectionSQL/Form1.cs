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

namespace _1_ConnectionSQL
{
    public partial class Form1 : Form
    {
        //tao 2 bien conn & dis
        string strCon = @"Data Source=HADUC25;Initial Catalog=QLThuVien;Integrated Security=True";

        //Đối tượng kết nối
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btConn_Click(object sender, EventArgs e)
        {
            try
            {
                //nếu = null -> tao sql moi
                if (sqlCon == null)
                {
                     sqlCon = new SqlConnection(strCon);
                }

                //Connection
                if (sqlCon.State == ConnectionState.Closed) //neu sql đóng->mở sql
                {
                    sqlCon.Open();
                    MessageBox.Show("Connected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDis_Click(object sender, EventArgs e)
        {
            //neu sqlCon != null & sqlCon.state đang mở -> đóng sql
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Disconnected");
            }
            else
            {
                MessageBox.Show("Connection to Sql Server, Please !");
            }
        }
    }
}
