using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace OpenExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() {Filter = "Excel Workbook|*.xlsx"})
            {
                if(ofd.ShowDialog() == DialogResult.OK) 
                {
                    tbFilename.Text = ofd.FileName;
                    using(var stream = File.Open(ofd.FileName,FileMode.Open,FileAccess.Read))
                    {
                        using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable =(_)=>new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                cbbSheet.Items.Add(table.TableName); //add sheet combobox
                            }
                        }
                    }
                }
            }
        }

        private void cbbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = tableCollection[cbbSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dataTable;
        }
    }
}
