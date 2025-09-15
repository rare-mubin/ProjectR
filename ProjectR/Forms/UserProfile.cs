using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectR.Forms
{
    public partial class UserProfile : UserControl
    {
        private DataAccess Da { get; set; }

        public UserProfile()
        {
            InitializeComponent();
            this.lblUserNameHeader.Text = MainWindow.LogInUser.Rows[0][2].ToString();
            this.lblUserDOBDetails.Text = MainWindow.LogInUser.Rows[0][3].ToString();
            this.lblNidNumberDetails.Text = MainWindow.LogInUser.Rows[0][5].ToString();
            this.lblPhoneDetails.Text = MainWindow.LogInUser.Rows[0][4].ToString();


        }

        private void ChangeWindow(UserControl NextPage)
        {
            MainWindow.MainWindowPanel.Controls.Clear();
            MainWindow.SidePanel.Visible = true;
            MainWindow.MainWindowPanel.Controls.Add(NextPage);
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditUserProfile editUserProfile = new EditUserProfile();

            editUserProfile.Dock=DockStyle.Fill;
            ChangeWindow(editUserProfile);
            editUserProfile.Show();
        }
    }
}
