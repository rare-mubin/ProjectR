using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectR.Forms
{
    public partial class LogIn : UserControl
    {
        private static bool txtUserIDClick { get; set; } = true;
        private static bool txtPassClick {  get; set; }= true;
        private const String DefaultTextBoxID  = "Enter your User-Id";
        private const String DefaultTextBoxPassword = "Enter your Password";
        private void DraggableWindows(Form a)
        {
            DragableWindow.MakeDraggable(a);
            DragableWindow.MakePanelDraggable(this.pnlMain, a);
        }

        public LogIn()
        {
            InitializeComponent();
        }
        public LogIn(Form a) : this()
        {
            DraggableWindows(a);
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            if (this.txtUserID.Text == "")
            {
                this.txtUserID.Text = DefaultTextBoxID;
                txtUserIDClick = true;
            }
        }

        private void txtUserID_Click(object sender, EventArgs e)
        {
            if (txtUserIDClick)
            {
                this.txtUserID.Text = "";
                txtUserIDClick = false;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (!ckbShowPassword.Checked)
                this.txtPassword.UseSystemPasswordChar = true;

            if (txtPassClick)
            {
                this.txtPassword.Text = "";
                txtPassClick = false;
            }
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassword.Checked)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else if (!ckbShowPassword.Checked)
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.ckbShowPassword.Visible = true;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == DefaultTextBoxPassword || this.txtUserID.Text == DefaultTextBoxID)
            {
                this.lblLoginValidation.Visible = true;
                this.lblLoginValidation.Text = "Please enter user-id and password";
                return;
            }

            try
            {
                var query = $@"select UserList.UserId,
                                UserList.UserPassword,
                                UserList.Username,
                                UserList.UserDOB,
                                UserList.UserPhone,
                                UserList.UserNID,
                                RoleList.Role,
                                UserList.PicturePath from 
                                UserList,RoleList 
                                where UserList.UserId = '{this.txtUserID.Text}' 
                                and UserList.UserPassword = '{this.txtPassword.Text}' 
                                and UserList.UserId = RoleList.UserId;";

                var ds = MainWindow.SqlDataAccess.ExecuteQueryTable(query);
                MainWindow.LogInUser = ds;

                if (ds.Rows.Count == 1)
                {
                    HomePage NextPage = new HomePage();
                    NextPage.Dock = DockStyle.Fill;
                    MainWindow.MainWindowPanel.Controls.Clear();
                    MainWindow.SidePanel.Visible = true;
                    MainWindow.MyProfile.Text = ds.Rows[0][2].ToString();
                    MainWindow.MainWindowPanel.Controls.Add(NextPage);
                    NextPage.Show();
                    ClearTxt();
                    txtPassClick = true;
                    txtUserIDClick = true;

                    if (MainWindow.LogInUser.Rows[0][6].ToString() == "Admin")
                    {
                        MainWindow.AdminAccessOnlyBtn(true);
                        return;
                    }
                }
                else
                {
                    this.lblLoginValidation.Text = "Invalid User";
                    this.lblLoginValidation.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void ClearTxt()
        {
            this.txtPassword.Text = DefaultTextBoxPassword;
            this.txtUserID.Text = DefaultTextBoxID;
            this.txtPassword.UseSystemPasswordChar = false;
            this.ckbShowPassword.Visible = false;
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword NextPage = new ForgotPassword(this);
            NextPage.Dock = DockStyle.Fill;
            MainWindow.MainWindowPanel.Controls.Clear();
            MainWindow.MainWindowPanel.Controls.Add(NextPage);
            NextPage.Show();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {
                this.txtPassword.UseSystemPasswordChar = false;
                this.txtPassword.Text = DefaultTextBoxPassword;
                this.ckbShowPassword.Visible = false;
                txtPassClick = true;
            }
        }
    }
}
