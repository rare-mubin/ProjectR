using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectR.Forms
{
    public partial class EditUserProfile : UserControl
    {
        private DataAccess Da {  get; set; }
        public EditUserProfile()
        {
            InitializeComponent();
            this.lblUserNameHeader.Text = MainWindow.LogInUser.Rows[0][2].ToString();
            this.txtUserName.Text = MainWindow.LogInUser.Rows[0][2].ToString();
            this.txtNidNumber.Text = MainWindow.LogInUser.Rows[0][5].ToString();
            this.txtPhone.Text = MainWindow.LogInUser.Rows[0][4].ToString();
            this.txtUserDOB.Text = MainWindow.LogInUser.Rows[0][3].ToString();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            if(this.txtUserName.Text ==""|| this.txtNidNumber.Text == ""|| this.txtPhone.Text == "")
            {
                MessageBox.Show("Please fill up all the required fields");
            }
            else {
                var Query = "update UserList set UserName='" + this.txtUserName.Text + "',UserNID='" + this.txtNidNumber.Text + "',UserPhone='" + this.txtPhone.Text + "' where UserId='A-001';";
                MainWindow.SqlDataAccess.ExecuteQuery(Query);
                MessageBox.Show("Profile has been updated");
                this.lblUserNameHeader.Text=this.txtUserName.Text;
            }
        }

        private void ChangeWindow(UserControl userProfile)
        {
            MainWindow.MainWindowPanel.Controls.Clear();
            MainWindow.SidePanel.Visible = true;
            MainWindow.MainWindowPanel.Controls.Add(userProfile);
        }

        private void btnBackToUserProfile_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.Dock = DockStyle.Fill;
            ChangeWindow(userProfile);
            userProfile.Show();
        }
    }
}
