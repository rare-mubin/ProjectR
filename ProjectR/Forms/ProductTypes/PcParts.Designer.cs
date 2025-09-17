namespace ProjectR.Forms.ProductTypes
{
    partial class PcParts
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
            this.btnMotherboard = new System.Windows.Forms.Button();
            this.btnProccessor = new System.Windows.Forms.Button();
            this.btnGPU = new System.Windows.Forms.Button();
            this.btnAccessories = new System.Windows.Forms.Button();
            this.btnAllPcParts = new System.Windows.Forms.Button();
            this.btnPSU = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnRAM = new System.Windows.Forms.Button();
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
            this.flpProducts.TabIndex = 4;
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.btnPSU);
            this.pnlCategory.Controls.Add(this.btnStorage);
            this.pnlCategory.Controls.Add(this.btnRAM);
            this.pnlCategory.Controls.Add(this.btnMotherboard);
            this.pnlCategory.Controls.Add(this.btnProccessor);
            this.pnlCategory.Controls.Add(this.btnGPU);
            this.pnlCategory.Controls.Add(this.btnAccessories);
            this.pnlCategory.Controls.Add(this.btnAllPcParts);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(800, 69);
            this.pnlCategory.TabIndex = 5;
            // 
            // btnMotherboard
            // 
            this.btnMotherboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMotherboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotherboard.ForeColor = System.Drawing.Color.White;
            this.btnMotherboard.Location = new System.Drawing.Point(394, 23);
            this.btnMotherboard.Name = "btnMotherboard";
            this.btnMotherboard.Size = new System.Drawing.Size(75, 23);
            this.btnMotherboard.TabIndex = 4;
            this.btnMotherboard.Text = "Motherboard";
            this.btnMotherboard.UseVisualStyleBackColor = true;
            this.btnMotherboard.Click += new System.EventHandler(this.btnMotherboard_Click);
            // 
            // btnProccessor
            // 
            this.btnProccessor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnProccessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProccessor.ForeColor = System.Drawing.Color.White;
            this.btnProccessor.Location = new System.Drawing.Point(313, 23);
            this.btnProccessor.Name = "btnProccessor";
            this.btnProccessor.Size = new System.Drawing.Size(75, 23);
            this.btnProccessor.TabIndex = 3;
            this.btnProccessor.Text = "Proccessor";
            this.btnProccessor.UseVisualStyleBackColor = true;
            this.btnProccessor.Click += new System.EventHandler(this.btnProccessor_Click);
            // 
            // btnGPU
            // 
            this.btnGPU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGPU.ForeColor = System.Drawing.Color.White;
            this.btnGPU.Location = new System.Drawing.Point(232, 23);
            this.btnGPU.Name = "btnGPU";
            this.btnGPU.Size = new System.Drawing.Size(75, 23);
            this.btnGPU.TabIndex = 2;
            this.btnGPU.Text = "GPU";
            this.btnGPU.UseVisualStyleBackColor = true;
            this.btnGPU.Click += new System.EventHandler(this.btnGPU_Click);
            // 
            // btnAccessories
            // 
            this.btnAccessories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccessories.ForeColor = System.Drawing.Color.White;
            this.btnAccessories.Location = new System.Drawing.Point(151, 23);
            this.btnAccessories.Name = "btnAccessories";
            this.btnAccessories.Size = new System.Drawing.Size(75, 23);
            this.btnAccessories.TabIndex = 1;
            this.btnAccessories.Text = "Accessories";
            this.btnAccessories.UseVisualStyleBackColor = true;
            this.btnAccessories.Click += new System.EventHandler(this.btnAccessories_Click);
            // 
            // btnAllPcParts
            // 
            this.btnAllPcParts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAllPcParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllPcParts.ForeColor = System.Drawing.Color.White;
            this.btnAllPcParts.Location = new System.Drawing.Point(70, 23);
            this.btnAllPcParts.Name = "btnAllPcParts";
            this.btnAllPcParts.Size = new System.Drawing.Size(75, 23);
            this.btnAllPcParts.TabIndex = 0;
            this.btnAllPcParts.Text = "All Pc Parts";
            this.btnAllPcParts.UseVisualStyleBackColor = true;
            this.btnAllPcParts.Click += new System.EventHandler(this.btnAllPcParts_Click);
            // 
            // btnPSU
            // 
            this.btnPSU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPSU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSU.ForeColor = System.Drawing.Color.White;
            this.btnPSU.Location = new System.Drawing.Point(639, 23);
            this.btnPSU.Name = "btnPSU";
            this.btnPSU.Size = new System.Drawing.Size(75, 23);
            this.btnPSU.TabIndex = 7;
            this.btnPSU.Text = "PSU";
            this.btnPSU.UseVisualStyleBackColor = true;
            this.btnPSU.Click += new System.EventHandler(this.btnPSU_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorage.ForeColor = System.Drawing.Color.White;
            this.btnStorage.Location = new System.Drawing.Point(558, 23);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(75, 23);
            this.btnStorage.TabIndex = 6;
            this.btnStorage.Text = "Storage";
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnRAM
            // 
            this.btnRAM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRAM.ForeColor = System.Drawing.Color.White;
            this.btnRAM.Location = new System.Drawing.Point(477, 23);
            this.btnRAM.Name = "btnRAM";
            this.btnRAM.Size = new System.Drawing.Size(75, 23);
            this.btnRAM.TabIndex = 5;
            this.btnRAM.Text = "RAM";
            this.btnRAM.UseVisualStyleBackColor = true;
            this.btnRAM.Click += new System.EventHandler(this.btnRAM_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 6;
            // 
            // PcParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.pnlCategory);
            this.Name = "PcParts";
            this.Size = new System.Drawing.Size(800, 630);
            this.Load += new System.EventHandler(this.PcParts_Load);
            this.pnlCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Button btnMotherboard;
        private System.Windows.Forms.Button btnProccessor;
        private System.Windows.Forms.Button btnGPU;
        private System.Windows.Forms.Button btnAccessories;
        private System.Windows.Forms.Button btnAllPcParts;
        private System.Windows.Forms.Button btnPSU;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Button btnRAM;
        private System.Windows.Forms.Panel panel1;
    }
}
