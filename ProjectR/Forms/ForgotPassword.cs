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
    public partial class ForgotPassword : UserControl
    {
        private static bool txtUserIDClick { get; set; } = true;
        private static bool txtNIDClick { get; set; } = true;
        private static bool txtNPassClick { get; set; } = true;
        private static bool txtCPassClick { get; set; } = true;

        private const String DefaultTextBoxID = "Enter your User-Id";
        private const String DefaultTextBoxNID = "Enter your NID";
        private const String DefaultTextBoxNPassword = "Enter New Password";
        private const String DefaultTextBoxCPassword = "Enter New Password Again";

        private UserControl LoginP {  get; set; }

        public ForgotPassword()
        {
            InitializeComponent();
        }

        public ForgotPassword(UserControl a) : this()
        {
            this.LoginP = a;
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

        private void txtNID_Leave(object sender, EventArgs e)
        {
            if (this.txtNID.Text == "")
            {
                this.txtNID.Text = DefaultTextBoxNID;
                txtNIDClick = true;
            }
        }

        private void txtNID_Click(object sender, EventArgs e)
        {
            if (txtNIDClick)
            {
                this.txtNID.Text = "";
                txtNIDClick = false;
            }
        }

        private void txtPasswordC_Click(object sender, EventArgs e)
        {
            if (!ckbShowPasswordC.Checked)
                this.txtPasswordC.UseSystemPasswordChar = true;

            if (txtCPassClick)
            {
                this.txtPasswordC.Text = "";
                txtCPassClick = false;
            }
        }

        private void txtPasswordN_Click(object sender, EventArgs e)
        {
            if (!ckbShowPasswordN.Checked)
                this.txtPasswordN.UseSystemPasswordChar = true;

            if (txtNPassClick)
            {
                this.txtPasswordN.Text = "";
                txtNPassClick = false;
            }
        }

        private void ckbShowPasswordN_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPasswordN.Checked)
            {
                this.txtPasswordN.UseSystemPasswordChar = false;
            }
            else if (!ckbShowPasswordN.Checked)
            {
                this.txtPasswordN.UseSystemPasswordChar = true;
            }
        }

        private void ckbShowPasswordC_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPasswordC.Checked)
            {
                this.txtPasswordC.UseSystemPasswordChar = false;
            }
            else if (!ckbShowPasswordC.Checked)
            {
                this.txtPasswordC.UseSystemPasswordChar = true;
            }
        }

        private void txtPasswordN_Leave(object sender, EventArgs e)
        {
            if (this.txtPasswordN.Text == "")
            {
                this.txtPasswordN.UseSystemPasswordChar = false;
                this.txtPasswordN.Text = DefaultTextBoxNPassword;
                this.ckbShowPasswordN.Visible = false;
                txtNPassClick = true;
            }
        }
        private void txtPasswordC_Leave(object sender, EventArgs e)
        {
            if (this.txtPasswordC.Text == "")
            {
                this.txtPasswordC.UseSystemPasswordChar = false;
                this.txtPasswordC.Text = DefaultTextBoxCPassword;
                this.ckbShowPasswordC.Visible = false;
                txtCPassClick = true;
            }
        }


        private void txtPasswordN_TextChanged(object sender, EventArgs e)
        {
            this.ckbShowPasswordN.Visible = true;
        }
        private void txtPasswordC_TextChanged(object sender, EventArgs e)
        {
            this.ckbShowPasswordC.Visible = true;
        }

        private void ClearTxt()
        {
            this.txtPasswordC.Text = DefaultTextBoxCPassword;
            this.txtPasswordN.Text = DefaultTextBoxNPassword;
            this.txtUserID.Text = DefaultTextBoxID;
            this.txtNID.Text = DefaultTextBoxNID;
            this.txtPasswordC.UseSystemPasswordChar = false;
            this.txtPasswordN.UseSystemPasswordChar = false;
            this.ckbShowPasswordN.Visible = false;
            this.ckbShowPasswordC.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.txtPasswordN.Text == DefaultTextBoxNPassword || this.txtPasswordC.Text == DefaultTextBoxCPassword ||
                this.txtUserID.Text == DefaultTextBoxID ||
                this.txtNID.Text == DefaultTextBoxNID)
            {
                this.lblConfirmValidation.Visible = true;
                this.lblConfirmValidation.ForeColor = Color.Red;
                this.lblConfirmValidation.Text = "Please Fill  All details";
                return;
            }

            if (!(this.txtPasswordN.Text == this.txtPasswordC.Text))
            {
                this.lblConfirmValidation.Visible = true;
                this.lblConfirmValidation.ForeColor = Color.Red;
                this.lblConfirmValidation.Text = "New Password and Confirm Password Does't Match!";
                return;
            }

            try
            {
                var da = MainWindow.SqlDataAccess.ExecuteQueryTable($"Select * from UserList Where UserId = '{this.txtUserID.Text}' and UserNID = '{this.txtNID.Text}';");
                if (da.Rows.Count == 0)
                {
                    this.lblConfirmValidation.Visible = true;
                    this.lblConfirmValidation.ForeColor = Color.Red;
                    this.lblConfirmValidation.Text = "Wrong User ID or NID";
                    return;
                }

                MainWindow.SqlDataAccess.ExecuteDMLQuery($"UPDATE UserList SET UserPassword = '{this.txtPasswordC.Text}' WHERE UserId = '{this.txtUserID.Text}'");
                this.lblConfirmValidation.Visible = true;
                this.lblConfirmValidation.ForeColor = Color.Green;
                this.lblConfirmValidation.Text = "Pasword Change Successfull";
                this.ClearTxt();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.ClearTxt();
            this.LoginP.Dock = DockStyle.Fill;
            MainWindow.MainWindowPanel.Controls.Clear();
            MainWindow.MainWindowPanel.Controls.Add(this.LoginP);
            this.LoginP.Show();
        }

        private void txtNID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
