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

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            connectSQL();
            refresh();

        }

        string strCon = @"Data Source=HADUC25;Initial Catalog=QLDIEMTHI;Integrated Security=True";

        SqlConnection sqlCon = null;


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

        void refresh()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from SINHVIEN", sqlCon);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dgv.DataSource = dtbl;
        }
        #endregion

        private void btn_ngatketnoi_Click(object sender, EventArgs e)
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
