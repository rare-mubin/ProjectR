namespace ProjectR.Forms
{
    partial class SellerList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSellerList = new System.Windows.Forms.DataGridView();
            this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserNID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.txtSearchSellers = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pnlProductbtns = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserNID = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlSidebarRight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellerList)).BeginInit();
            this.pnlGridView.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pnlProductbtns.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSidebarRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSellerList
            // 
            this.dgvSellerList.AllowUserToAddRows = false;
            this.dgvSellerList.AllowUserToDeleteRows = false;
            this.dgvSellerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.dgvSellerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSellerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSellerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSellerList.ColumnHeadersHeight = 40;
            this.dgvSellerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSellerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserId,
            this.colUserName,
            this.colUserDOB,
            this.colUserPhone,
            this.colUserNID,
            this.colUserRole,
            this.colUserPassword});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSellerList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSellerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSellerList.EnableHeadersVisualStyles = false;
            this.dgvSellerList.Location = new System.Drawing.Point(20, 0);
            this.dgvSellerList.Name = "dgvSellerList";
            this.dgvSellerList.ReadOnly = true;
            this.dgvSellerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSellerList.RowHeadersVisible = false;
            this.dgvSellerList.RowHeadersWidth = 51;
            this.dgvSellerList.RowTemplate.Height = 40;
            this.dgvSellerList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSellerList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSellerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSellerList.Size = new System.Drawing.Size(780, 630);
            this.dgvSellerList.TabIndex = 0;
            this.dgvSellerList.DoubleClick += new System.EventHandler(this.dgvSellerList_DoubleClick);
            // 
            // colUserId
            // 
            this.colUserId.DataPropertyName = "UserId";
            this.colUserId.HeaderText = "User Id";
            this.colUserId.Name = "colUserId";
            this.colUserId.ReadOnly = true;
            // 
            // colUserName
            // 
            this.colUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserName.DataPropertyName = "Username";
            this.colUserName.HeaderText = "Name";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colUserDOB
            // 
            this.colUserDOB.DataPropertyName = "UserDOB";
            this.colUserDOB.HeaderText = "Date of Birth";
            this.colUserDOB.Name = "colUserDOB";
            this.colUserDOB.ReadOnly = true;
            // 
            // colUserPhone
            // 
            this.colUserPhone.DataPropertyName = "UserPhone";
            this.colUserPhone.HeaderText = "Phone Number";
            this.colUserPhone.Name = "colUserPhone";
            this.colUserPhone.ReadOnly = true;
            this.colUserPhone.Width = 150;
            // 
            // colUserNID
            // 
            this.colUserNID.DataPropertyName = "UserNID";
            this.colUserNID.HeaderText = "NID";
            this.colUserNID.Name = "colUserNID";
            this.colUserNID.ReadOnly = true;
            // 
            // colUserRole
            // 
            this.colUserRole.DataPropertyName = "Role";
            this.colUserRole.HeaderText = "Role";
            this.colUserRole.Name = "colUserRole";
            this.colUserRole.ReadOnly = true;
            // 
            // colUserPassword
            // 
            this.colUserPassword.DataPropertyName = "UserPassword";
            this.colUserPassword.HeaderText = "Password";
            this.colUserPassword.Name = "colUserPassword";
            this.colUserPassword.ReadOnly = true;
            this.colUserPassword.Visible = false;
            // 
            // pnlGridView
            // 
            this.pnlGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.pnlGridView.Controls.Add(this.dgvSellerList);
            this.pnlGridView.Location = new System.Drawing.Point(5, 54);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlGridView.Size = new System.Drawing.Size(800, 630);
            this.pnlGridView.TabIndex = 7;
            // 
            // txtSearchSellers
            // 
            this.txtSearchSellers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.txtSearchSellers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchSellers.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtSearchSellers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtSearchSellers.Location = new System.Drawing.Point(30, 10);
            this.txtSearchSellers.Name = "txtSearchSellers";
            this.txtSearchSellers.Size = new System.Drawing.Size(738, 21);
            this.txtSearchSellers.TabIndex = 0;
            this.txtSearchSellers.Text = "Search Users...";
            this.txtSearchSellers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchSellers.Click += new System.EventHandler(this.txtSearchSellers_Click);
            this.txtSearchSellers.TextChanged += new System.EventHandler(this.txtSearchSellers_TextChanged);
            this.txtSearchSellers.Leave += new System.EventHandler(this.txtSearchSellers_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtSearchSellers);
            this.panel4.Location = new System.Drawing.Point(5, 6);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.panel4.Size = new System.Drawing.Size(800, 44);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add or Update Product";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(812, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(283, 44);
            this.panel2.TabIndex = 4;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnDeleteUser.Location = new System.Drawing.Point(7, 5);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnDeleteUser.Size = new System.Drawing.Size(267, 30);
            this.btnDeleteUser.TabIndex = 0;
            this.btnDeleteUser.Text = "Delete User Information";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel11.Controls.Add(this.btnDeleteUser);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(1, 85);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.panel11.Size = new System.Drawing.Size(281, 42);
            this.panel11.TabIndex = 8;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnUpdateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnUpdateUser.Location = new System.Drawing.Point(7, 7);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnUpdateUser.Size = new System.Drawing.Size(267, 30);
            this.btnUpdateUser.TabIndex = 0;
            this.btnUpdateUser.Text = "Clear";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel10.Controls.Add(this.btnUpdateUser);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(1, 43);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(7, 7, 7, 5);
            this.panel10.Size = new System.Drawing.Size(281, 42);
            this.panel10.TabIndex = 9;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAddUser.Location = new System.Drawing.Point(7, 7);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnAddUser.Size = new System.Drawing.Size(267, 30);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Save User Information";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pnlProductbtns
            // 
            this.pnlProductbtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlProductbtns.Controls.Add(this.panel3);
            this.pnlProductbtns.Controls.Add(this.panel10);
            this.pnlProductbtns.Controls.Add(this.panel11);
            this.pnlProductbtns.Location = new System.Drawing.Point(812, 556);
            this.pnlProductbtns.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProductbtns.Name = "pnlProductbtns";
            this.pnlProductbtns.Padding = new System.Windows.Forms.Padding(1);
            this.pnlProductbtns.Size = new System.Drawing.Size(283, 128);
            this.pnlProductbtns.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.btnAddUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(7, 7, 7, 5);
            this.panel3.Size = new System.Drawing.Size(281, 42);
            this.panel3.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtUserName.Location = new System.Drawing.Point(26, 116);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(231, 21);
            this.txtUserName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "User Name";
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserId.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtUserId.Location = new System.Drawing.Point(26, 50);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(231, 21);
            this.txtUserId.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "User Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtUserNID);
            this.panel1.Controls.Add(this.txtUserPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbUserRole);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUserPhone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 493);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label9.Location = new System.Drawing.Point(0, 468);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label9.Size = new System.Drawing.Size(281, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Double Click Row For Update/Delete";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(26, 241);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(230, 20);
            this.dtpDOB.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label8.Location = new System.Drawing.Point(26, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Role";
            // 
            // txtUserNID
            // 
            this.txtUserNID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtUserNID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNID.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserNID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtUserNID.Location = new System.Drawing.Point(25, 364);
            this.txtUserNID.Name = "txtUserNID";
            this.txtUserNID.Size = new System.Drawing.Size(231, 21);
            this.txtUserNID.TabIndex = 34;
            this.txtUserNID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserPhone_KeyPress);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtUserPassword.Location = new System.Drawing.Point(25, 181);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(231, 21);
            this.txtUserPassword.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(25, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Password";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "Seller"});
            this.cmbUserRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.cmbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUserRole.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cmbUserRole.ForeColor = System.Drawing.Color.White;
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Admin",
            "Salesman"});
            this.cmbUserRole.Location = new System.Drawing.Point(26, 419);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(231, 28);
            this.cmbUserRole.TabIndex = 31;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.cmbUserRole_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(26, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "NID";
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtUserPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPhone.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtUserPhone.Location = new System.Drawing.Point(25, 305);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(231, 21);
            this.txtUserPhone.TabIndex = 28;
            this.txtUserPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserPhone_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(25, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Contact Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(25, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Date Of Birth";
            // 
            // pnlSidebarRight
            // 
            this.pnlSidebarRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlSidebarRight.Controls.Add(this.panel1);
            this.pnlSidebarRight.Location = new System.Drawing.Point(812, 54);
            this.pnlSidebarRight.Name = "pnlSidebarRight";
            this.pnlSidebarRight.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSidebarRight.Size = new System.Drawing.Size(283, 495);
            this.pnlSidebarRight.TabIndex = 8;
            // 
            // SellerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectR.Properties.Resources.usercontrolBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.pnlGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlProductbtns);
            this.Controls.Add(this.pnlSidebarRight);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SellerList";
            this.Size = new System.Drawing.Size(1100, 690);
            this.Load += new System.EventHandler(this.SellerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellerList)).EndInit();
            this.pnlGridView.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.pnlProductbtns.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSidebarRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSellerList;
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.TextBox txtSearchSellers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel pnlProductbtns;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSidebarRight;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserNID;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserNID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserPassword;
        private System.Windows.Forms.Label label9;
    }
}
