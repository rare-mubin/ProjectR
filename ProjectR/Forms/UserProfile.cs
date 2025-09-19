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
        public UserProfile()
        {
            InitializeComponent();
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
            this.ChangeWindow(editUserProfile);
            editUserProfile.Show();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            try
            {
                this.ptbProfilePic.Image = Image.FromFile(MainWindow.LogInUser.Rows[0][7].ToString());
            }
            catch { }

            try
            {
                this.lblUserNameHeader.Text = MainWindow.LogInUser.Rows[0][2].ToString();
                this.lblUserDOBDetails.Text = MainWindow.LogInUser.Rows[0][3].ToString();
                this.lblNidNumberDetails.Text = MainWindow.LogInUser.Rows[0][5].ToString();
                this.lblPhoneDetails.Text = MainWindow.LogInUser.Rows[0][4].ToString();
                this.lblUserRole.Text = MainWindow.LogInUser.Rows[0][6].ToString();

                var dt = MainWindow.SqlDataAccess.ExecuteQueryTable($"select sum(TotalAmount) from TransactionList where SalesmanID = '{MainWindow.LogInUser.Rows[0][0].ToString()}'");
                this.lblTotalSellsDetails.Text = dt.Rows[0][0].ToString() + " BDT";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
