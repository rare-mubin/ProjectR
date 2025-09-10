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

namespace ProjectR
{
    public partial class LogIn : Form
    {
        private static bool txtUserIDClick = true , txtPassClick = true;
        private void DraggableWindows()
        {
            DragableWindow.MakeDraggable(this);
            DragableWindow.MakePanelDraggable(pnlMain, this);
            DragableWindow.MakePanelDraggable(pnlTittlebar, this);
        }

        public LogIn()
        {
            InitializeComponent();
            DraggableWindows();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            if (this.txtPassword.Text == "Enter your Password" && this.txtUserID.Text == "Enter your User-Id")
            {
                this.lblLoginValidation.Visible = true;
                this.lblLoginValidation.Text = "Please enter user-id and password";
                return;
            }

            var query = "select * from AppUser where UserId = '" + this.txtUserID.Text + "' and Password = '" + this.txtPassword.Text + "'";

            SqlConnection sqlcon = new SqlConnection("Data Source=RARE\\SQLEXPRESS;Initial Catalog=ProjectR_DB;Persist Security Info=True;User ID=ProjectR;Password=okay1;");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.lblLoginValidation.Text = "Valid user "+ ds.Tables[0].Rows[0][3].ToString();
            }
            else this.lblLoginValidation.Text = "Invalid User";
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
