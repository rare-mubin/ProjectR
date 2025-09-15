namespace ProjectR.Forms
{
    partial class UserProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserDOB = new System.Windows.Forms.Label();
            this.lblUserNameHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNidNumberDetails = new System.Windows.Forms.Label();
            this.lblPhoneDetails = new System.Windows.Forms.Label();
            this.lblTotalSellsDetails = new System.Windows.Forms.Label();
            this.lblUserDOBDetails = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ldlNidNumber = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTotalSells = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(79, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 190);
            this.panel2.TabIndex = 3;
            // 
            // lblUserDOB
            // 
            this.lblUserDOB.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.lblUserDOB.Location = new System.Drawing.Point(196, 223);
            this.lblUserDOB.Name = "lblUserDOB";
            this.lblUserDOB.Size = new System.Drawing.Size(197, 46);
            this.lblUserDOB.TabIndex = 1;
            this.lblUserDOB.Text = "Date Of Birth";
            // 
            // lblUserNameHeader
            // 
            this.lblUserNameHeader.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.lblUserNameHeader.Location = new System.Drawing.Point(326, 35);
            this.lblUserNameHeader.Name = "lblUserNameHeader";
            this.lblUserNameHeader.Size = new System.Drawing.Size(369, 55);
            this.lblUserNameHeader.TabIndex = 0;
            this.lblUserNameHeader.Text = "User Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNidNumberDetails);
            this.panel1.Controls.Add(this.lblPhoneDetails);
            this.panel1.Controls.Add(this.lblTotalSellsDetails);
            this.panel1.Controls.Add(this.lblUserDOBDetails);
            this.panel1.Controls.Add(this.btnEditProfile);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ldlNidNumber);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblTotalSells);
            this.panel1.Controls.Add(this.lblUserDOB);
            this.panel1.Controls.Add(this.lblUserNameHeader);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 540);
            this.panel1.TabIndex = 2;
            // 
            // lblNidNumberDetails
            // 
            this.lblNidNumberDetails.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNidNumberDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.lblNidNumberDetails.Location = new System.Drawing.Point(642, 292);
            this.lblNidNumberDetails.Name = "lblNidNumberDetails";
            this.lblNidNumberDetails.Size = new System.Drawing.Size(195, 46);
            this.lblNidNumberDetails.TabIndex = 14;
            this.lblNidNumberDetails.Text = "Nid Number";
            // 
            // lblPhoneDetails
            // 
            this.lblPhoneDetails.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.lblPhoneDetails.Location = new System.Drawing.Point(642, 362);
            this.lblPhoneDetails.Name = "lblPhoneDetails";
            this.lblPhoneDetails.Size = new System.Drawing.Size(195, 46);
            this.lblPhoneDetails.TabIndex = 13;
            this.lblPhoneDetails.Text = "Phone Number";
            // 
            // lblTotalSellsDetails
            // 
            this.lblTotalSellsDetails.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSellsDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.lblTotalSellsDetails.Location = new System.Drawing.Point(642, 430);
            this.lblTotalSellsDetails.Name = "lblTotalSellsDetails";
            this.lblTotalSellsDetails.Size = new System.Drawing.Size(195, 46);
            this.lblTotalSellsDetails.TabIndex = 12;
            this.lblTotalSellsDetails.Text = "Total Sells";
            // 
            // lblUserDOBDetails
            // 
            this.lblUserDOBDetails.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDOBDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.lblUserDOBDetails.Location = new System.Drawing.Point(642, 223);
            this.lblUserDOBDetails.Name = "lblUserDOBDetails";
            this.lblUserDOBDetails.Size = new System.Drawing.Size(195, 46);
            this.lblUserDOBDetails.TabIndex = 11;
            this.lblUserDOBDetails.Text = "Date Of Birth";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile.Location = new System.Drawing.Point(917, 447);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(106, 29);
            this.btnEditProfile.TabIndex = 10;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.label10.Location = new System.Drawing.Point(328, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 46);
            this.label10.TabIndex = 9;
            this.label10.Text = "Admin";
            // 
            // ldlNidNumber
            // 
            this.ldlNidNumber.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlNidNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.ldlNidNumber.Location = new System.Drawing.Point(196, 292);
            this.ldlNidNumber.Name = "ldlNidNumber";
            this.ldlNidNumber.Size = new System.Drawing.Size(197, 46);
            this.ldlNidNumber.TabIndex = 4;
            this.ldlNidNumber.Text = "Nid Number";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.lblPhone.Location = new System.Drawing.Point(196, 362);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(197, 46);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblTotalSells
            // 
            this.lblTotalSells.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSells.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.lblTotalSells.Location = new System.Drawing.Point(196, 430);
            this.lblTotalSells.Name = "lblTotalSells";
            this.lblTotalSells.Size = new System.Drawing.Size(197, 46);
            this.lblTotalSells.TabIndex = 2;
            this.lblTotalSells.Text = "Total Sells";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectR.Properties.Resources.usercontrolBackground;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(1100, 690);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserDOB;
        private System.Windows.Forms.Label lblUserNameHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ldlNidNumber;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTotalSells;
        private System.Windows.Forms.Label lblNidNumberDetails;
        private System.Windows.Forms.Label lblPhoneDetails;
        private System.Windows.Forms.Label lblTotalSellsDetails;
        private System.Windows.Forms.Label lblUserDOBDetails;
    }
}
