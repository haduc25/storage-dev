using System.Windows.Forms;

namespace ManagerPassword
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
            cbbSelecter.SelectedIndex = 0;
        }

        private void cbbSelecter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOpen.PerformClick();
        }

        private void btnOpen_Click(object sender, System.EventArgs e)
        {
            switch (cbbSelecter.SelectedIndex)
            {
                case 0:
                    FormManagerProtectYourBookmark bookmark = new FormManagerProtectYourBookmark();
                    bookmark.ShowDialog();
                    break;
                case 1:
                    FormManagerProtectYourPassword pwd = new FormManagerProtectYourPassword();
                    pwd.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Some error there!");
                    break;
            }
        }
    }
}
