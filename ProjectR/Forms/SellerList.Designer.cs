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
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.txtSearchSellers = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pnlProductbtns = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSidebarRight = new System.Windows.Forms.Panel();
            this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
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
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserId,
            this.colUserName,
            this.colUserRole,
            this.colUserPassword});
            this.dgvProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductList.Location = new System.Drawing.Point(0, 0);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(800, 630);
            this.dgvProductList.TabIndex = 0;
            // 
            // pnlGridView
            // 
            this.pnlGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.pnlGridView.Controls.Add(this.dgvProductList);
            this.pnlGridView.Location = new System.Drawing.Point(5, 54);
            this.pnlGridView.Name = "pnlGridView";
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
            this.txtSearchSellers.Text = "Search product with name or id";
            this.txtSearchSellers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnDeleteProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(7, 5);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnDeleteProduct.Size = new System.Drawing.Size(267, 30);
            this.btnDeleteProduct.TabIndex = 0;
            this.btnDeleteProduct.Text = "Delete Seller Information";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel11.Controls.Add(this.btnDeleteProduct);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(1, 85);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.panel11.Size = new System.Drawing.Size(281, 42);
            this.panel11.TabIndex = 8;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnUpdateProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateProduct.FlatAppearance.BorderSize = 0;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnUpdateProduct.Location = new System.Drawing.Point(7, 7);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnUpdateProduct.Size = new System.Drawing.Size(267, 30);
            this.btnUpdateProduct.TabIndex = 0;
            this.btnUpdateProduct.Text = "Update Seller Information";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel10.Controls.Add(this.btnUpdateProduct);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(1, 43);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(7, 7, 7, 5);
            this.panel10.Size = new System.Drawing.Size(281, 42);
            this.panel10.TabIndex = 9;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAddProduct.Location = new System.Drawing.Point(7, 7);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnAddProduct.Size = new System.Drawing.Size(267, 30);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Seller";
            this.btnAddProduct.UseVisualStyleBackColor = false;
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
            this.panel3.Controls.Add(this.btnAddProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(7, 7, 7, 5);
            this.panel3.Size = new System.Drawing.Size(281, 42);
            this.panel3.TabIndex = 10;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "Seller"});
            this.cmbUserRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.cmbUserRole.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cmbUserRole.ForeColor = System.Drawing.Color.White;
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Laptop",
            "Digital Store",
            "Personal Computer"});
            this.cmbUserRole.Location = new System.Drawing.Point(26, 206);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(231, 28);
            this.cmbUserRole.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(26, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "User Category";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtUserName.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(26, 134);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(231, 26);
            this.txtUserName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "User Name";
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtUserId.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtUserId.ForeColor = System.Drawing.Color.White;
            this.txtUserId.Location = new System.Drawing.Point(26, 68);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(231, 26);
            this.txtUserId.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "User Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.cmbUserRole);
            this.panel1.Controls.Add(this.label5);
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
            // colUserId
            // 
            this.colUserId.HeaderText = "User Id";
            this.colUserId.Name = "colUserId";
            this.colUserId.ReadOnly = true;
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "Name";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colUserRole
            // 
            this.colUserRole.HeaderText = "Role";
            this.colUserRole.Name = "colUserRole";
            this.colUserRole.ReadOnly = true;
            // 
            // colUserPassword
            // 
            this.colUserPassword.HeaderText = "Password";
            this.colUserPassword.Name = "colUserPassword";
            this.colUserPassword.ReadOnly = true;
            this.colUserPassword.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.TextBox txtSearchSellers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel pnlProductbtns;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSidebarRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserPassword;
    }
}
