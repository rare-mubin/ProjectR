using ProjectR.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFADBCRUDN;

namespace ProjectR
{
    public partial class LogIn : Form
    {
        internal Form MainWindowF { get; set; }

        private static bool txtUserIDClick = true , txtPassClick = true;
        private void DraggableWindows(Form a)
        {
            DragableWindow.MakeDraggable(a);
            DragableWindow.MakePanelDraggable(pnlMain, a);
        }

        public LogIn()
        {
            InitializeComponent();
        }
        public LogIn(Form a) : this()
        {
            DraggableWindows(a);
            this.MainWindowF = a;
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            if (this.txtUserID.Text == "")
            {
                this.txtUserID.Text = "Enter your User-Id";
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
            if(!ckbShowPassword.Checked)
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
            //this.lblLoginValidation.Text = "error";
            if (this.txtPassword.Text == "Enter your Password" || this.txtUserID.Text == "Enter your User-Id")
            {
                this.lblLoginValidation.Visible = true;
                this.lblLoginValidation.Text = "Please enter user-id and password";
                return;
            }

            var query = "select * from SuperUser where UserId = '" + this.txtUserID.Text + "' and Password = '" + this.txtPassword.Text + "'";

           

            DataAccess da = new DataAccess();
            var ds = da.ExecuteQueryTable(query);
            

            if (ds.Rows.Count == 1)
            {
                //this.lblLoginValidation.Text = "Valid user " + ds.Tables[0].Rows[0][3].ToString();
                HomePage homePage = new HomePage(MainWindowF, this);
                homePage.Dock = DockStyle.Fill;
                this.Hide();
                MainWindow.MainWindowPanel.Controls.Add(homePage);
                homePage.Show();
                ClearTxt();
                this.lblLoginValidation.Visible = false;
            }
            else 
            {
                this.lblLoginValidation.Text = "Invalid User";
                this.lblLoginValidation.Visible= true;
            }
        }

        private void ClearTxt()
        {
            this.txtPassword.Text = "Enter your Password";
            this.txtUserID.Text = "Enter your User-Id";
            this.txtPassword.UseSystemPasswordChar = false;
            this.ckbShowPassword.Visible = false;
        } 

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {
                this.txtPassword.UseSystemPasswordChar = false;
                this.txtPassword.Text = "Enter your Password";
                this.ckbShowPassword.Visible = false;
                txtPassClick = true;
            }
        }
    }
}
