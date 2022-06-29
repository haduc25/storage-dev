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


namespace Data_Query
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //thuc hanh 1/quan ly tv (path source sql qltv)
        string strCon = @"Data Source=HADUC25;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd;

        void connectSQL() 
        {
            if (sqlCon == null) 
            {
                sqlCon = new SqlConnection(strCon);
            }

            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                MessageBox.Show("Connected");
            }
        }
        
        void disconnectSQL()
        {
            if(sqlCon!=null && sqlCon.State == ConnectionState.Open) 
            {
                sqlCon.Close();
                MessageBox.Show("Disconnected");
            }
            else
            {
                MessageBox.Show("pls connect to sql server");

            }
        }

        void soluongSQL()
        {
            //doi tuong thuc thi truy van
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select count(*) from SACH"; //dem sl sach
        }















        private void btnQuery_Click(object sender, EventArgs e)
        {
            string data = txtData.Text.Trim(); //trim use remove space first and end
            MessageBox.Show(data);
       
        }
    }
}
