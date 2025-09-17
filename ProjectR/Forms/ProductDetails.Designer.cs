namespace ProjectR.Forms
{
    partial class ProductDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetails));
            this.pnlProductDetails1 = new System.Windows.Forms.Panel();
            this.ptbProductPicture = new System.Windows.Forms.PictureBox();
            this.pnlProductDetails2 = new System.Windows.Forms.Panel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblProductNameValue = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductModelValue = new System.Windows.Forms.Label();
            this.lblProductCategoryValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProductTypeValue = new System.Windows.Forms.Label();
            this.lblProductStocksValue = new System.Windows.Forms.Label();
            this.lblProductAmount = new System.Windows.Forms.Label();
            this.lblProductDescriptionValue = new System.Windows.Forms.Label();
            this.pnlProductDetails1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductPicture)).BeginInit();
            this.pnlProductDetails2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProductDetails1
            // 
            this.pnlProductDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.pnlProductDetails1.Controls.Add(this.ptbProductPicture);
            this.pnlProductDetails1.Location = new System.Drawing.Point(-1, -1);
            this.pnlProductDetails1.Name = "pnlProductDetails1";
            this.pnlProductDetails1.Size = new System.Drawing.Size(800, 630);
            this.pnlProductDetails1.TabIndex = 0;
            // 
            // ptbProductPicture
            // 
            this.ptbProductPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ptbProductPicture.Location = new System.Drawing.Point(31, 42);
            this.ptbProductPicture.Name = "ptbProductPicture";
            this.ptbProductPicture.Size = new System.Drawing.Size(348, 543);
            this.ptbProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProductPicture.TabIndex = 0;
            this.ptbProductPicture.TabStop = false;
            // 
            // pnlProductDetails2
            // 
            this.pnlProductDetails2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.pnlProductDetails2.Controls.Add(this.lblProductDescriptionValue);
            this.pnlProductDetails2.Controls.Add(this.lblProductAmount);
            this.pnlProductDetails2.Controls.Add(this.lblProductStocksValue);
            this.pnlProductDetails2.Controls.Add(this.lblProductTypeValue);
            this.pnlProductDetails2.Controls.Add(this.label7);
            this.pnlProductDetails2.Controls.Add(this.label6);
            this.pnlProductDetails2.Controls.Add(this.label5);
            this.pnlProductDetails2.Controls.Add(this.label4);
            this.pnlProductDetails2.Controls.Add(this.lblProductCategoryValue);
            this.pnlProductDetails2.Controls.Add(this.lblProductModelValue);
            this.pnlProductDetails2.Controls.Add(this.label1);
            this.pnlProductDetails2.Controls.Add(this.btnAddToCart);
            this.pnlProductDetails2.Controls.Add(this.lblProductNameValue);
            this.pnlProductDetails2.Controls.Add(this.lblProductName);
            this.pnlProductDetails2.ForeColor = System.Drawing.Color.White;
            this.pnlProductDetails2.Location = new System.Drawing.Point(411, -1);
            this.pnlProductDetails2.Name = "pnlProductDetails2";
            this.pnlProductDetails2.Size = new System.Drawing.Size(800, 630);
            this.pnlProductDetails2.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.AutoSize = true;
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(225, 548);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(112, 37);
            this.btnAddToCart.TabIndex = 14;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblProductNameValue
            // 
            this.lblProductNameValue.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductNameValue.ForeColor = System.Drawing.Color.White;
            this.lblProductNameValue.Location = new System.Drawing.Point(22, 64);
            this.lblProductNameValue.Name = "lblProductNameValue";
            this.lblProductNameValue.Size = new System.Drawing.Size(230, 32);
            this.lblProductNameValue.TabIndex = 7;
            this.lblProductNameValue.Text = "Product Name";
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductName.ForeColor = System.Drawing.Color.Gray;
            this.lblProductName.Location = new System.Drawing.Point(26, 42);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(142, 22);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product Model";
            // 
            // lblProductModelValue
            // 
            this.lblProductModelValue.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductModelValue.ForeColor = System.Drawing.Color.White;
            this.lblProductModelValue.Location = new System.Drawing.Point(25, 118);
            this.lblProductModelValue.Name = "lblProductModelValue";
            this.lblProductModelValue.Size = new System.Drawing.Size(230, 25);
            this.lblProductModelValue.TabIndex = 16;
            this.lblProductModelValue.Text = "Product Model";
            // 
            // lblProductCategoryValue
            // 
            this.lblProductCategoryValue.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductCategoryValue.ForeColor = System.Drawing.Color.White;
            this.lblProductCategoryValue.Location = new System.Drawing.Point(25, 165);
            this.lblProductCategoryValue.Name = "lblProductCategoryValue";
            this.lblProductCategoryValue.Size = new System.Drawing.Size(230, 34);
            this.lblProductCategoryValue.TabIndex = 17;
            this.lblProductCategoryValue.Text = "Product Category";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(24, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Product Category";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Product Type";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(26, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Product Stocks";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(26, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Product Description";
            // 
            // lblProductTypeValue
            // 
            this.lblProductTypeValue.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductTypeValue.ForeColor = System.Drawing.Color.White;
            this.lblProductTypeValue.Location = new System.Drawing.Point(25, 212);
            this.lblProductTypeValue.Name = "lblProductTypeValue";
            this.lblProductTypeValue.Size = new System.Drawing.Size(230, 29);
            this.lblProductTypeValue.TabIndex = 22;
            this.lblProductTypeValue.Text = "Product Type";
            // 
            // lblProductStocksValue
            // 
            this.lblProductStocksValue.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductStocksValue.ForeColor = System.Drawing.Color.White;
            this.lblProductStocksValue.Location = new System.Drawing.Point(25, 264);
            this.lblProductStocksValue.Name = "lblProductStocksValue";
            this.lblProductStocksValue.Size = new System.Drawing.Size(230, 29);
            this.lblProductStocksValue.TabIndex = 23;
            this.lblProductStocksValue.Text = "Product Stocks";
            // 
            // lblProductAmount
            // 
            this.lblProductAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductAmount.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductAmount.ForeColor = System.Drawing.Color.White;
            this.lblProductAmount.Location = new System.Drawing.Point(30, 548);
            this.lblProductAmount.Name = "lblProductAmount";
            this.lblProductAmount.Size = new System.Drawing.Size(148, 37);
            this.lblProductAmount.TabIndex = 25;
            this.lblProductAmount.Text = "Product Amount";
            this.lblProductAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductDescriptionValue
            // 
            this.lblProductDescriptionValue.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductDescriptionValue.ForeColor = System.Drawing.Color.White;
            this.lblProductDescriptionValue.Location = new System.Drawing.Point(26, 315);
            this.lblProductDescriptionValue.Name = "lblProductDescriptionValue";
            this.lblProductDescriptionValue.Size = new System.Drawing.Size(312, 187);
            this.lblProductDescriptionValue.TabIndex = 26;
            this.lblProductDescriptionValue.Text = resources.GetString("lblProductDescriptionValue.Text");
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectR.Properties.Resources.usercontrolBackground;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlProductDetails2);
            this.Controls.Add(this.pnlProductDetails1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProductDetails";
            this.Size = new System.Drawing.Size(800, 630);
            this.pnlProductDetails1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductPicture)).EndInit();
            this.pnlProductDetails2.ResumeLayout(false);
            this.pnlProductDetails2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductDetails1;
        private System.Windows.Forms.PictureBox ptbProductPicture;
        private System.Windows.Forms.Panel pnlProductDetails2;
        private System.Windows.Forms.Label lblProductNameValue;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProductCategoryValue;
        private System.Windows.Forms.Label lblProductModelValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductStocksValue;
        private System.Windows.Forms.Label lblProductTypeValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProductAmount;
        private System.Windows.Forms.Label lblProductDescriptionValue;
    }
}
