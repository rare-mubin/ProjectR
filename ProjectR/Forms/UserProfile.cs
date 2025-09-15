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
        internal Form MainWindowF { get; set; }
        private DataAccess Da { get; set; }

        public UserProfile()
        {
            InitializeComponent();
            var Query = "select * from UserList where UserId LIKE 'A%';";
            Da= new DataAccess();
            var dt=Da.ExecuteQuery(Query);
            this.lblUserNameHeader.Text = dt.Tables[0].Rows[0][2].ToString();
            this.lblUserDOBDetails.Text = dt.Tables[0].Rows[0][3].ToString();
            this.lblNidNumberDetails.Text = dt.Tables[0].Rows[0][5].ToString();
            this.lblPhoneDetails.Text = dt.Tables[0].Rows[0][4].ToString();


        }

        private void ChangeWindow(UserControl NextPage)
        {
            MainWindow.MainWindowPanel.Controls.Clear();
            MainWindow.SidePanel.Visible = true;
            MainWindow.MainWindowPanel.Controls.Add(NextPage);
        }

        public UserProfile(Form a) : this()
        {
            this.MainWindowF = a;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditUserProfile editUserProfile = new EditUserProfile(MainWindowF);

            editUserProfile.Dock=DockStyle.Fill;
            ChangeWindow(editUserProfile);
            editUserProfile.Show();
            

        }
    }
}
