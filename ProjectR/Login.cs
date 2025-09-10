using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void txtPassword_Click(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = true;
            if (txtPassClick)
            {
                this.txtPassword.Text = "";
                txtPassClick = false;
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {
                this.txtPassword.UseSystemPasswordChar = false;
                this.txtPassword.Text = "Enter your Password";
                txtPassClick = true;
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
    }
}
