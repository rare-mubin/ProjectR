namespace ProjectR
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ckbShowPassword = new System.Windows.Forms.CheckBox();
            this.lblLoginValidation = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnForgotPass = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTittlebar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTittlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.pnlMain.BackgroundImage = global::ProjectR.Properties.Resources.main_panel;
            this.pnlMain.Controls.Add(this.ckbShowPassword);
            this.pnlMain.Controls.Add(this.lblLoginValidation);
            this.pnlMain.Controls.Add(this.btnLogIn);
            this.pnlMain.Controls.Add(this.btnForgotPass);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.txtUserID);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnlTittlebar);
            this.pnlMain.Location = new System.Drawing.Point(1, 1);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1278, 718);
            this.pnlMain.TabIndex = 0;
            // 
            // ckbShowPassword
            // 
            this.ckbShowPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbShowPassword.Location = new System.Drawing.Point(404, 445);
            this.ckbShowPassword.Name = "ckbShowPassword";
            this.ckbShowPassword.Size = new System.Drawing.Size(15, 15);
            this.ckbShowPassword.TabIndex = 14;
            this.ckbShowPassword.UseVisualStyleBackColor = true;
            this.ckbShowPassword.Visible = false;
            this.ckbShowPassword.CheckedChanged += new System.EventHandler(this.ckbShowPassword_CheckedChanged);
            // 
            // lblLoginValidation
            // 
            this.lblLoginValidation.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginValidation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginValidation.ForeColor = System.Drawing.Color.Red;
            this.lblLoginValidation.Location = new System.Drawing.Point(91, 527);
            this.lblLoginValidation.Margin = new System.Windows.Forms.Padding(0);
            this.lblLoginValidation.Name = "lblLoginValidation";
            this.lblLoginValidation.Size = new System.Drawing.Size(325, 24);
            this.lblLoginValidation.TabIndex = 12;
            this.lblLoginValidation.Text = "Please enter your details";
            this.lblLoginValidation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginValidation.Visible = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(95, 560);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(321, 47);
            this.btnLogIn.TabIndex = 11;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.btnForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgotPass.FlatAppearance.BorderSize = 0;
            this.btnForgotPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(29)))));
            this.btnForgotPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPass.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnForgotPass.ForeColor = System.Drawing.Color.White;
            this.btnForgotPass.Location = new System.Drawing.Point(248, 481);
            this.btnForgotPass.Margin = new System.Windows.Forms.Padding(0);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(182, 30);
            this.btnForgotPass.TabIndex = 10;
            this.btnForgotPass.Text = "Forgot your password?";
            this.btnForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnForgotPass.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.panel3.Location = new System.Drawing.Point(95, 470);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 1);
            this.panel3.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtPassword.Location = new System.Drawing.Point(95, 441);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(306, 19);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Enter your Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.panel2.Location = new System.Drawing.Point(95, 362);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 1);
            this.panel2.TabIndex = 7;
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtUserID.Location = new System.Drawing.Point(95, 333);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(321, 19);
            this.txtUserID.TabIndex = 6;
            this.txtUserID.Text = "Enter your User-Id";
            this.txtUserID.Click += new System.EventHandler(this.txtUserID_Click);
            this.txtUserID.Leave += new System.EventHandler(this.txtUserID_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 403);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "User-Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.label2.Location = new System.Drawing.Point(166, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please enter your details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(138, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 1);
            this.panel1.TabIndex = 1;
            // 
            // pnlTittlebar
            // 
            this.pnlTittlebar.Controls.Add(this.btnMinimize);
            this.pnlTittlebar.Controls.Add(this.btnExit);
            this.pnlTittlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTittlebar.Location = new System.Drawing.Point(0, 0);
            this.pnlTittlebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTittlebar.Name = "pnlTittlebar";
            this.pnlTittlebar.Size = new System.Drawing.Size(1278, 28);
            this.pnlTittlebar.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1222, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 28);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1250, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectR";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTittlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTittlebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnForgotPass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblLoginValidation;
        private System.Windows.Forms.CheckBox ckbShowPassword;
    }
}

