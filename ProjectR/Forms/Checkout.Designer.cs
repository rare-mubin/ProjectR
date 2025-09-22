namespace ProjectR.Forms
{
    partial class Checkout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.pnlProductType = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dgvTempCart = new System.Windows.Forms.DataGridView();
            this.colProductIdTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductNameTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductQuantityTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmountTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMemberPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSelectPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnRedeemPoint = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtMemberPoints = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSellerID = new System.Windows.Forms.Label();
            this.lblMembershipPoints = new System.Windows.Forms.Label();
            this.lblTotalItem = new System.Windows.Forms.Label();
            this.lblGenerateTransitionID = new System.Windows.Forms.Label();
            this.pnlSidebarRight = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNewQuantity = new System.Windows.Forms.TextBox();
            this.btnChangeQuantity = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnConfirmTransaction = new System.Windows.Forms.Button();
            this.pnlProductbtns = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotaAfterDiscount = new System.Windows.Forms.Label();
            this.pnlProducts.SuspendLayout();
            this.pnlProductType.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempCart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlSidebarRight.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.pnlProductbtns.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.pnlProducts.Controls.Add(this.pnlProductType);
            this.pnlProducts.Location = new System.Drawing.Point(5, 54);
            this.pnlProducts.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Padding = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.pnlProducts.Size = new System.Drawing.Size(800, 630);
            this.pnlProducts.TabIndex = 14;
            // 
            // pnlProductType
            // 
            this.pnlProductType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.pnlProductType.Controls.Add(this.panel12);
            this.pnlProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductType.Location = new System.Drawing.Point(10, 1);
            this.pnlProductType.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProductType.Name = "pnlProductType";
            this.pnlProductType.Size = new System.Drawing.Size(789, 628);
            this.pnlProductType.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel12.Controls.Add(this.dgvTempCart);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(789, 628);
            this.panel12.TabIndex = 0;
            // 
            // dgvTempCart
            // 
            this.dgvTempCart.AllowUserToAddRows = false;
            this.dgvTempCart.AllowUserToDeleteRows = false;
            this.dgvTempCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.dgvTempCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTempCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTempCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTempCart.ColumnHeadersHeight = 40;
            this.dgvTempCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTempCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductIdTemp,
            this.colProductNameTemp,
            this.colProductQuantityTemp,
            this.colTotalAmountTemp,
            this.colProductUnitPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTempCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTempCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTempCart.EnableHeadersVisualStyles = false;
            this.dgvTempCart.Location = new System.Drawing.Point(0, 0);
            this.dgvTempCart.Name = "dgvTempCart";
            this.dgvTempCart.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTempCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTempCart.RowHeadersVisible = false;
            this.dgvTempCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTempCart.RowTemplate.Height = 40;
            this.dgvTempCart.RowTemplate.ReadOnly = true;
            this.dgvTempCart.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTempCart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTempCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTempCart.Size = new System.Drawing.Size(789, 628);
            this.dgvTempCart.TabIndex = 0;
            // 
            // colProductIdTemp
            // 
            this.colProductIdTemp.DataPropertyName = "ProductId";
            this.colProductIdTemp.HeaderText = "ID";
            this.colProductIdTemp.Name = "colProductIdTemp";
            this.colProductIdTemp.ReadOnly = true;
            // 
            // colProductNameTemp
            // 
            this.colProductNameTemp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductNameTemp.DataPropertyName = "ProductName";
            this.colProductNameTemp.HeaderText = "Product Name";
            this.colProductNameTemp.Name = "colProductNameTemp";
            this.colProductNameTemp.ReadOnly = true;
            // 
            // colProductQuantityTemp
            // 
            this.colProductQuantityTemp.DataPropertyName = "ProductQuantity";
            this.colProductQuantityTemp.HeaderText = "Quantity";
            this.colProductQuantityTemp.Name = "colProductQuantityTemp";
            this.colProductQuantityTemp.ReadOnly = true;
            // 
            // colTotalAmountTemp
            // 
            this.colTotalAmountTemp.DataPropertyName = "TotalAmount";
            this.colTotalAmountTemp.HeaderText = "Total";
            this.colTotalAmountTemp.Name = "colTotalAmountTemp";
            this.colTotalAmountTemp.ReadOnly = true;
            // 
            // colProductUnitPrice
            // 
            this.colProductUnitPrice.DataPropertyName = "ProductUnitPrice";
            this.colProductUnitPrice.HeaderText = "Unit Price";
            this.colProductUnitPrice.Name = "colProductUnitPrice";
            this.colProductUnitPrice.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.txtMemberPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbSelectPaymentMethod);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.lblSellerID);
            this.panel1.Controls.Add(this.lblMembershipPoints);
            this.panel1.Controls.Add(this.lblTotalItem);
            this.panel1.Controls.Add(this.lblGenerateTransitionID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 441);
            this.panel1.TabIndex = 0;
            // 
            // txtMemberPhone
            // 
            this.txtMemberPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtMemberPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemberPhone.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtMemberPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtMemberPhone.Location = new System.Drawing.Point(19, 151);
            this.txtMemberPhone.Name = "txtMemberPhone";
            this.txtMemberPhone.Size = new System.Drawing.Size(242, 21);
            this.txtMemberPhone.TabIndex = 18;
            this.txtMemberPhone.TextChanged += new System.EventHandler(this.txtMemberPhone_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(48, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Member Phone ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSelectPaymentMethod
            // 
            this.cmbSelectPaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.cmbSelectPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.cmbSelectPaymentMethod.FormattingEnabled = true;
            this.cmbSelectPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Digital"});
            this.cmbSelectPaymentMethod.Location = new System.Drawing.Point(19, 95);
            this.cmbSelectPaymentMethod.Name = "cmbSelectPaymentMethod";
            this.cmbSelectPaymentMethod.Size = new System.Drawing.Size(243, 21);
            this.cmbSelectPaymentMethod.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label4.Location = new System.Drawing.Point(48, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Select Payment Method";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnRedeemPoint);
            this.panel9.Location = new System.Drawing.Point(135, 231);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(128, 30);
            this.panel9.TabIndex = 14;
            // 
            // btnRedeemPoint
            // 
            this.btnRedeemPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnRedeemPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRedeemPoint.FlatAppearance.BorderSize = 0;
            this.btnRedeemPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedeemPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnRedeemPoint.Location = new System.Drawing.Point(0, 0);
            this.btnRedeemPoint.Name = "btnRedeemPoint";
            this.btnRedeemPoint.Size = new System.Drawing.Size(128, 30);
            this.btnRedeemPoint.TabIndex = 0;
            this.btnRedeemPoint.Text = "Redeem Point";
            this.btnRedeemPoint.UseVisualStyleBackColor = false;
            this.btnRedeemPoint.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel8.Controls.Add(this.txtMemberPoints);
            this.panel8.Location = new System.Drawing.Point(18, 231);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(101, 30);
            this.panel8.TabIndex = 11;
            // 
            // txtMemberPoints
            // 
            this.txtMemberPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtMemberPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemberPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtMemberPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtMemberPoints.Location = new System.Drawing.Point(0, 3);
            this.txtMemberPoints.Name = "txtMemberPoints";
            this.txtMemberPoints.Size = new System.Drawing.Size(101, 23);
            this.txtMemberPoints.TabIndex = 0;
            this.txtMemberPoints.Text = "000";
            this.txtMemberPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(15, 336);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(179, 23);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "Total Amount : ";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.lblDiscount.Location = new System.Drawing.Point(16, 381);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(179, 23);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "Discount : ";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSellerID
            // 
            this.lblSellerID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.lblSellerID.Location = new System.Drawing.Point(48, 39);
            this.lblSellerID.Name = "lblSellerID";
            this.lblSellerID.Size = new System.Drawing.Size(179, 23);
            this.lblSellerID.TabIndex = 6;
            this.lblSellerID.Text = "Seller ID";
            this.lblSellerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMembershipPoints
            // 
            this.lblMembershipPoints.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.lblMembershipPoints.Location = new System.Drawing.Point(16, 189);
            this.lblMembershipPoints.Name = "lblMembershipPoints";
            this.lblMembershipPoints.Size = new System.Drawing.Size(245, 23);
            this.lblMembershipPoints.TabIndex = 3;
            this.lblMembershipPoints.Text = "Membership Points :   ";
            this.lblMembershipPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.lblTotalItem.Location = new System.Drawing.Point(15, 290);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(179, 23);
            this.lblTotalItem.TabIndex = 2;
            this.lblTotalItem.Text = "Total Item : ";
            this.lblTotalItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenerateTransitionID
            // 
            this.lblGenerateTransitionID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateTransitionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.lblGenerateTransitionID.Location = new System.Drawing.Point(48, 12);
            this.lblGenerateTransitionID.Name = "lblGenerateTransitionID";
            this.lblGenerateTransitionID.Size = new System.Drawing.Size(179, 23);
            this.lblGenerateTransitionID.TabIndex = 1;
            this.lblGenerateTransitionID.Text = "Generate Transaction ID";
            this.lblGenerateTransitionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSidebarRight
            // 
            this.pnlSidebarRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlSidebarRight.Controls.Add(this.panel1);
            this.pnlSidebarRight.Location = new System.Drawing.Point(812, 54);
            this.pnlSidebarRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebarRight.Name = "pnlSidebarRight";
            this.pnlSidebarRight.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSidebarRight.Size = new System.Drawing.Size(283, 443);
            this.pnlSidebarRight.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnChangeQuantity);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(7, 7, 7, 5);
            this.panel3.Size = new System.Drawing.Size(281, 42);
            this.panel3.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel6.Controls.Add(this.txtNewQuantity);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(7, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(122, 30);
            this.panel6.TabIndex = 2;
            // 
            // txtNewQuantity
            // 
            this.txtNewQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtNewQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtNewQuantity.ForeColor = System.Drawing.Color.White;
            this.txtNewQuantity.Location = new System.Drawing.Point(3, 4);
            this.txtNewQuantity.Name = "txtNewQuantity";
            this.txtNewQuantity.Size = new System.Drawing.Size(119, 23);
            this.txtNewQuantity.TabIndex = 1;
            this.txtNewQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewQuantity_KeyPress);
            // 
            // btnChangeQuantity
            // 
            this.btnChangeQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnChangeQuantity.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangeQuantity.FlatAppearance.BorderSize = 0;
            this.btnChangeQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeQuantity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnChangeQuantity.Location = new System.Drawing.Point(137, 7);
            this.btnChangeQuantity.Name = "btnChangeQuantity";
            this.btnChangeQuantity.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnChangeQuantity.Size = new System.Drawing.Size(137, 30);
            this.btnChangeQuantity.TabIndex = 0;
            this.btnChangeQuantity.Text = "Change Quantity";
            this.btnChangeQuantity.UseVisualStyleBackColor = false;
            this.btnChangeQuantity.Click += new System.EventHandler(this.btnChangeQuantity_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel10.Controls.Add(this.btnRemoveFromCart);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(1, 43);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(7, 7, 7, 5);
            this.panel10.Size = new System.Drawing.Size(281, 42);
            this.panel10.TabIndex = 9;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnRemoveFromCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveFromCart.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnRemoveFromCart.Location = new System.Drawing.Point(7, 7);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnRemoveFromCart.Size = new System.Drawing.Size(267, 30);
            this.btnRemoveFromCart.TabIndex = 0;
            this.btnRemoveFromCart.Text = "Delete Item From Cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = false;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel11.Controls.Add(this.btnConfirmTransaction);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(1, 85);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.panel11.Size = new System.Drawing.Size(281, 42);
            this.panel11.TabIndex = 8;
            // 
            // btnConfirmTransaction
            // 
            this.btnConfirmTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnConfirmTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmTransaction.FlatAppearance.BorderSize = 0;
            this.btnConfirmTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmTransaction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnConfirmTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnConfirmTransaction.Location = new System.Drawing.Point(7, 5);
            this.btnConfirmTransaction.Name = "btnConfirmTransaction";
            this.btnConfirmTransaction.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnConfirmTransaction.Size = new System.Drawing.Size(267, 30);
            this.btnConfirmTransaction.TabIndex = 0;
            this.btnConfirmTransaction.Text = "Confirm Transaction";
            this.btnConfirmTransaction.UseVisualStyleBackColor = false;
            this.btnConfirmTransaction.Click += new System.EventHandler(this.btnConfirmTransaction_Click);
            // 
            // pnlProductbtns
            // 
            this.pnlProductbtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlProductbtns.Controls.Add(this.panel3);
            this.pnlProductbtns.Controls.Add(this.panel10);
            this.pnlProductbtns.Controls.Add(this.panel11);
            this.pnlProductbtns.Location = new System.Drawing.Point(813, 556);
            this.pnlProductbtns.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProductbtns.Name = "pnlProductbtns";
            this.pnlProductbtns.Padding = new System.Windows.Forms.Padding(1);
            this.pnlProductbtns.Size = new System.Drawing.Size(283, 128);
            this.pnlProductbtns.TabIndex = 12;
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
            this.panel2.TabIndex = 10;
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
            this.label1.Text = "Enter Payments Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnBack.Location = new System.Drawing.Point(12, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(5, 6);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.panel4.Size = new System.Drawing.Size(800, 44);
            this.panel4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(30, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(740, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shoping Cart";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.lblTotaAfterDiscount);
            this.panel5.Location = new System.Drawing.Point(812, 505);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(1);
            this.panel5.Size = new System.Drawing.Size(283, 44);
            this.panel5.TabIndex = 11;
            // 
            // lblTotaAfterDiscount
            // 
            this.lblTotaAfterDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.lblTotaAfterDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotaAfterDiscount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTotaAfterDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.lblTotaAfterDiscount.Location = new System.Drawing.Point(1, 1);
            this.lblTotaAfterDiscount.Name = "lblTotaAfterDiscount";
            this.lblTotaAfterDiscount.Size = new System.Drawing.Size(281, 42);
            this.lblTotaAfterDiscount.TabIndex = 2;
            this.lblTotaAfterDiscount.Text = "0.00 BDT";
            this.lblTotaAfterDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BackgroundImage = global::ProjectR.Properties.Resources.usercontrolBackground;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.pnlSidebarRight);
            this.Controls.Add(this.pnlProductbtns);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Checkout";
            this.Size = new System.Drawing.Size(1100, 690);
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.pnlProducts.ResumeLayout(false);
            this.pnlProductType.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnlSidebarRight.ResumeLayout(false);
            this.pnlSidebarRight.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.pnlProductbtns.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Panel pnlProductType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSidebarRight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChangeQuantity;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnConfirmTransaction;
        private System.Windows.Forms.Panel pnlProductbtns;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotaAfterDiscount;
        private System.Windows.Forms.Label lblSellerID;
        private System.Windows.Forms.Label lblMembershipPoints;
        private System.Windows.Forms.Label lblTotalItem;
        private System.Windows.Forms.Label lblGenerateTransitionID;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtNewQuantity;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtMemberPoints;
        private System.Windows.Forms.Button btnRedeemPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSelectPaymentMethod;
        private System.Windows.Forms.TextBox txtMemberPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTempCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductIdTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductNameTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductQuantityTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmountTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductUnitPrice;
        private System.Windows.Forms.Panel panel6;
    }
}
