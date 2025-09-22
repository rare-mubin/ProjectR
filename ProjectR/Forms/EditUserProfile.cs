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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectR.Forms
{
    public partial class EditUserProfile : UserControl
    {
        private DataAccess Da {  get; set; }
        internal static string destinationFilePath { get; set; }
        public EditUserProfile()
        {
            InitializeComponent();
            this.lblUserNameHeader.Text = MainWindow.LogInUser.Rows[0][2].ToString();
            this.txtUserName.Text = MainWindow.LogInUser.Rows[0][2].ToString();
            this.lblUserRole1.Text = MainWindow.LogInUser.Rows[0][6].ToString();
            this.txtNidNumber.Text = MainWindow.LogInUser.Rows[0][5].ToString();
            this.txtPhone.Text = MainWindow.LogInUser.Rows[0][4].ToString();
            this.dtpDOB.Text = MainWindow.LogInUser.Rows[0][3].ToString();
        }

        private void EditUserProfile_Load(object sender, EventArgs e)
        {
            try
            {
                this.ptbProfilePic.Image = Image.FromFile(MainWindow.LogInUser.Rows[0][7].ToString());
            }
            catch { }
        }
        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtUserName.Text == "" || this.txtNidNumber.Text == "" || this.txtPhone.Text == "")
                {
                    MessageBox.Show("Please fill up all the required fields");
                }
                else
                {
                    if (this.txtFilePath.Text != "")
                    {
                        updatePicture();
                    }
                    destinationFilePath = MainWindow.LogInUser.Rows[0][7].ToString();
                    var Query = "update UserList set UserName='" + this.txtUserName.Text + "',UserNID='" + this.txtNidNumber.Text + "',UserPhone='" + this.txtPhone.Text + "', PicturePath ='" + destinationFilePath + "' where UserId='" + MainWindow.LogInUser.Rows[0][0].ToString() + "';";
                    MainWindow.SqlDataAccess.ExecuteQuery(Query);
                    
                    MessageBox.Show("Profile has been updated");

                    var query = $@"select UserList.UserId,
                                UserList.UserPassword,
                                UserList.Username,
                                UserList.UserDOB,
                                UserList.UserPhone,
                                UserList.UserNID,
                                RoleList.Role,
                                UserList.PicturePath from 
                                UserList,RoleList 
                                where UserList.UserId = '{MainWindow.LogInUser.Rows[0][0].ToString()}'  
                                and UserList.UserId = RoleList.UserId;";

                    var ds = MainWindow.SqlDataAccess.ExecuteQueryTable(query);
                    MainWindow.LogInUser = ds;
                    EditUserProfile NextPage = new EditUserProfile();
                    NextPage.Dock = DockStyle.Fill;
                    MainWindow.MainWindowPanel.Controls.Clear();
                    MainWindow.MainWindowPanel.Controls.Add(NextPage);
                    NextPage.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message);
            }
        }

        private void updatePicture()
        {
            //string sourceFilePath = this.ofdChoseFile.FileName;
            string sourceFilePath = this.txtFilePath.Text;
            string fileName = $"{MainWindow.LogInUser.Rows[0][0].ToString()}.png";
            destinationFilePath = Path.Combine(@"..\..\ProfileImage", fileName);

            string destinationDirectory = Path.GetDirectoryName(destinationFilePath);
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            try
            {
                File.Copy(sourceFilePath, destinationFilePath, true);
            }
            catch (Exception ex)
            {
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

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            this.ofdChoseFile.ShowDialog();
        }

        private void ofdChoseFile_FileOk(object sender, CancelEventArgs e)
        {
            this.txtFilePath.Text = this.ofdChoseFile.FileName;
        }

        private void txtNidNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
