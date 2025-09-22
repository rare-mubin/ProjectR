namespace ProjectR.Forms.ProductTypes.ProductsCards
{
    partial class ProductCard
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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ptbProductImage = new System.Windows.Forms.PictureBox();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.pnlCard.Controls.Add(this.lblProductStock);
            this.pnlCard.Controls.Add(this.lblProductName);
            this.pnlCard.Controls.Add(this.lblProductType);
            this.pnlCard.Controls.Add(this.btnAddToCart);
            this.pnlCard.Controls.Add(this.lblProductCategory);
            this.pnlCard.Controls.Add(this.lblPrice);
            this.pnlCard.Controls.Add(this.panel4);
            this.pnlCard.Controls.Add(this.panel3);
            this.pnlCard.Controls.Add(this.ptbProductImage);
            this.pnlCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(20, 18);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(342, 117);
            this.pnlCard.TabIndex = 1;
            this.pnlCard.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.lblProductName.Location = new System.Drawing.Point(86, 21);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(154, 18);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.BackColor = System.Drawing.Color.Transparent;
            this.lblProductType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblProductType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblProductType.Location = new System.Drawing.Point(86, 69);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(67, 12);
            this.lblProductType.TabIndex = 3;
            this.lblProductType.Text = "Product Type";
            this.lblProductType.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAddToCart.Location = new System.Drawing.Point(257, 78);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(70, 23);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblProductCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductCategory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblProductCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblProductCategory.Location = new System.Drawing.Point(86, 47);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(89, 12);
            this.lblProductCategory.TabIndex = 2;
            this.lblProductCategory.Text = "Product Category";
            this.lblProductCategory.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.lblPrice.Location = new System.Drawing.Point(244, 21);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 18);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(257, 56);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 1);
            this.panel4.TabIndex = 6;
            this.panel4.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(243, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 117);
            this.panel3.TabIndex = 5;
            this.panel3.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // ptbProductImage
            // 
            this.ptbProductImage.BackColor = System.Drawing.Color.DimGray;
            this.ptbProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbProductImage.Location = new System.Drawing.Point(14, 12);
            this.ptbProductImage.Margin = new System.Windows.Forms.Padding(0);
            this.ptbProductImage.Name = "ptbProductImage";
            this.ptbProductImage.Size = new System.Drawing.Size(59, 92);
            this.ptbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProductImage.TabIndex = 0;
            this.ptbProductImage.TabStop = false;
            this.ptbProductImage.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.BackColor = System.Drawing.Color.Transparent;
            this.lblProductStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductStock.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblProductStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblProductStock.Location = new System.Drawing.Point(87, 91);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(42, 12);
            this.lblProductStock.TabIndex = 8;
            this.lblProductStock.Text = "Stock : ";
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.pnlCard);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProductCard";
            this.Padding = new System.Windows.Forms.Padding(20, 18, 18, 15);
            this.Size = new System.Drawing.Size(380, 150);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.PictureBox ptbProductImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblProductStock;
    }
}
