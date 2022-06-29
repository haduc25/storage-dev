using System;
using System.Windows.Forms;

namespace Bai45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbDM.ReadOnly = true;
            tbTieuThu.ReadOnly = true;
            tbThanhTien.ReadOnly = true;
            tbTotal.ReadOnly = true;
            tbTotal.Text = "0";
            tbTotal.TextAlign = HorizontalAlignment.Right;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cbbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbRegion.Text == "Khu Vực 1")
            {
                tbDM.Text = "50";
            }
            else if(cbbRegion.Text == "Khu Vực 2")
            {
                tbDM.Text = "100";
            }
            else if(cbbRegion.Text == "Khu Vực 3")
            {
                tbDM.Text = "150";
            }
        }

        #region Keys Enter
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btTinhTien.PerformClick();
            }
        }

        private void tbDM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btTinhTien.PerformClick();
            }
        }

        private void tbSoCu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btTinhTien.PerformClick();
            }
        }

        private void tbSoMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btTinhTien.PerformClick();
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            VaildAndCaculater();

        }


        void VaildAndCaculater()
        {
            try 
            {
                int numb1 = 0, numb2 = 0;
                if (Int32.TryParse(tbSoMoi.Text, out numb1) && Int32.TryParse(tbSoCu.Text, out numb2))
                {
                    int soCu = Convert.ToInt32(tbSoCu.Text);
                    int soMoi = Convert.ToInt32(tbSoMoi.Text);
                    int dinhMuc = Convert.ToInt32(tbDM.Text);
                    if (soCu < soMoi)
                    {
                        int a = Convert.ToInt32(tbSoMoi.Text);
                        int b = Convert.ToInt32(tbSoCu.Text);
                        int tieuThu = soMoi - soCu;
                        tbTieuThu.Text = tieuThu.ToString();

                        int trongDM = 0, ngoaiDM = 0;
                        //money
                        int MoneyTrongDM = 1000, MoneyNgoaiDM = 2000;

                        //Caculater Money
                        if (tieuThu >= dinhMuc)
                        {
                            //trong Dinh Muc
                            trongDM = dinhMuc;

                            //ngoai Dinh Muc
                            ngoaiDM = tieuThu - dinhMuc;

                            int temp = trongDM * MoneyTrongDM + ngoaiDM * MoneyNgoaiDM;
                            tbThanhTien.Text = temp.ToString();
                        }
                        else
                        {
                            int temp = tieuThu * MoneyTrongDM;
                            tbThanhTien.Text = temp.ToString();
                           
                        }
                        addToListView();
                        total();
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ, Số mới phải lớn hơn số cũ !", "Thông báo");
                    }
                }
                else if (tbDM.Text == "")
                {
                    MessageBox.Show("Dữ liệu không hợp lệ, Vui lòng chọn định mức !", "Thông báo");
                }else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ, Vui lòng nhập số !", "Thông báo");
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }  
        } 

        void addToListView()
        {
            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(cbbRegion.Text) || string.IsNullOrEmpty(tbDM.Text) || string.IsNullOrEmpty(tbTieuThu.Text) || string.IsNullOrEmpty(tbThanhTien.Text))
            { return; }
            ListViewItem item = new ListViewItem(tbName.Text);
            item.SubItems.Add(cbbRegion.Text);
            item.SubItems.Add(tbDM.Text);
            item.SubItems.Add(tbTieuThu.Text);
            item.SubItems.Add(tbThanhTien.Text);
            listv.Items.Add(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Clear
            tbName.Clear();
            cbbRegion.SelectedIndex = -1;
            tbDM.Clear();
            tbTieuThu.Clear();
            tbThanhTien.Clear();
            tbSoCu.Clear();
            tbSoMoi.Clear();
            tbName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listv.SelectedItems.Count > 0)
            {
                DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (check == DialogResult.Yes)
                {
                    listv.Items.Remove(listv.SelectedItems[0]);
                    total();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Items cần xóa.", "Thông báo");
                return;
            }

        }
        void total()
        {
            tbTotal.Text = "0";
            decimal totalMoney = 0;
            for (int i = 0; i < listv.Items.Count; i++)
            {
                totalMoney += decimal.Parse(listv.Items[i].SubItems[4].Text);
            }
            tbTotal.Text = totalMoney.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
