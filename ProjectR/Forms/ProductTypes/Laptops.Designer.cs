namespace ProjectR.Forms.ProductTypes
{
    partial class Laptops
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
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.btnMacBook = new System.Windows.Forms.Button();
            this.btnGaming = new System.Windows.Forms.Button();
            this.btnCreator = new System.Windows.Forms.Button();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.btnAllLaptops = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProducts.Location = new System.Drawing.Point(0, 69);
            this.flpProducts.Margin = new System.Windows.Forms.Padding(0);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flpProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpProducts.Size = new System.Drawing.Size(800, 561);
            this.flpProducts.TabIndex = 2;
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.btnMacBook);
            this.pnlCategory.Controls.Add(this.btnGaming);
            this.pnlCategory.Controls.Add(this.btnCreator);
            this.pnlCategory.Controls.Add(this.btnBusiness);
            this.pnlCategory.Controls.Add(this.btnAllLaptops);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(800, 69);
            this.pnlCategory.TabIndex = 3;
            // 
            // btnMacBook
            // 
            this.btnMacBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMacBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMacBook.ForeColor = System.Drawing.Color.White;
            this.btnMacBook.Location = new System.Drawing.Point(580, 23);
            this.btnMacBook.Name = "btnMacBook";
            this.btnMacBook.Size = new System.Drawing.Size(75, 23);
            this.btnMacBook.TabIndex = 4;
            this.btnMacBook.Text = "MacBook";
            this.btnMacBook.UseVisualStyleBackColor = true;
            this.btnMacBook.Click += new System.EventHandler(this.btnMacBook_Click);
            // 
            // btnGaming
            // 
            this.btnGaming.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGaming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGaming.ForeColor = System.Drawing.Color.White;
            this.btnGaming.Location = new System.Drawing.Point(467, 23);
            this.btnGaming.Name = "btnGaming";
            this.btnGaming.Size = new System.Drawing.Size(75, 23);
            this.btnGaming.TabIndex = 3;
            this.btnGaming.Text = "Gaming";
            this.btnGaming.UseVisualStyleBackColor = true;
            this.btnGaming.Click += new System.EventHandler(this.btnGaming_Click);
            // 
            // btnCreator
            // 
            this.btnCreator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCreator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreator.ForeColor = System.Drawing.Color.White;
            this.btnCreator.Location = new System.Drawing.Point(354, 23);
            this.btnCreator.Name = "btnCreator";
            this.btnCreator.Size = new System.Drawing.Size(75, 23);
            this.btnCreator.TabIndex = 2;
            this.btnCreator.Text = "Creator";
            this.btnCreator.UseVisualStyleBackColor = true;
            this.btnCreator.Click += new System.EventHandler(this.btnCreator_Click);
            // 
            // btnBusiness
            // 
            this.btnBusiness.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusiness.ForeColor = System.Drawing.Color.White;
            this.btnBusiness.Location = new System.Drawing.Point(241, 23);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(75, 23);
            this.btnBusiness.TabIndex = 1;
            this.btnBusiness.Text = "Business";
            this.btnBusiness.UseVisualStyleBackColor = true;
            this.btnBusiness.Click += new System.EventHandler(this.btnBusiness_Click);
            // 
            // btnAllLaptops
            // 
            this.btnAllLaptops.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAllLaptops.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllLaptops.ForeColor = System.Drawing.Color.White;
            this.btnAllLaptops.Location = new System.Drawing.Point(128, 23);
            this.btnAllLaptops.Name = "btnAllLaptops";
            this.btnAllLaptops.Size = new System.Drawing.Size(75, 23);
            this.btnAllLaptops.TabIndex = 0;
            this.btnAllLaptops.Text = "All Laptops";
            this.btnAllLaptops.UseVisualStyleBackColor = true;
            this.btnAllLaptops.Click += new System.EventHandler(this.btnAllLaptops_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 4;
            // 
            // Laptops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.pnlCategory);
            this.Name = "Laptops";
            this.Size = new System.Drawing.Size(800, 630);
            this.Load += new System.EventHandler(this.Laptops_Load);
            this.pnlCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Button btnMacBook;
        private System.Windows.Forms.Button btnGaming;
        private System.Windows.Forms.Button btnCreator;
        private System.Windows.Forms.Button btnBusiness;
        private System.Windows.Forms.Button btnAllLaptops;
        private System.Windows.Forms.Panel panel1;
    }
}
