﻿using ProjectR.Forms.ProductTypes.ProductsCards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectR.Forms.ProductTypes
{
    public partial class PcParts : UserControl
    {
        internal DataAccess Da { get; set; }
        internal string productId { get; set; }
        internal string productName { get; set; }
        internal string productType { get; set; }
        internal string productCategory { get; set; }
        internal string productPrice { get; set; }
        internal string picturePath { get; set; }
        internal string query { get; set; }

        public PcParts(string query = "select * from ProductList Where ProductType = 'PcParts';")
        {
            InitializeComponent();
            this.Da = MainWindow.SqlDataAccess;
            this.query = query;
        }

        private void LoadProduct()
        {
            try
            {
                var ProductsTable = this.Da.ExecuteQueryTable(query);
                int Counter = 0;
                while (Counter < ProductsTable.Rows.Count)
                {
                    this.productId = ProductsTable.Rows[Counter][0].ToString();
                    this.productName = ProductsTable.Rows[Counter][1].ToString();
                    this.productCategory = ProductsTable.Rows[Counter][3].ToString();
                    this.productType = ProductsTable.Rows[Counter][2].ToString();
                    this.productPrice = ProductsTable.Rows[Counter][4].ToString();
                    this.picturePath = ProductsTable.Rows[Counter++][8].ToString();

                    ProductCard card = new ProductCard(this.productId, this.productName, this.productCategory, this.productType, this.productPrice, this.picturePath);

                    this.flpProducts.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void PcParts_Load(object sender, EventArgs e)
        {
            this.LoadProduct();
        }

        private void btnAllPcParts_Click(object sender, EventArgs e)
        {
            this.flpProducts.Controls.Clear();
            this.query = "select * from ProductList Where ProductType = 'PcParts';";
            this.LoadProduct();
        }

        private void btnAccessories_Click(object sender, EventArgs e)
        {
            this.flpProducts.Controls.Clear();
            this.query = "select * from ProductList Where ProductType = 'PcParts' and ProductCategory = 'Accessories';";
            this.LoadProduct();
        }

        private void btnGPU_Click(object sender, EventArgs e)
        {
            this.flpProducts.Controls.Clear();
            this.query = "select * from ProductList Where ProductType = 'PcParts' and ProductCategory = 'GPU';";
            this.LoadProduct();
        }

        private void btnProccessor_Click(object sender, EventArgs e)
        {
            this.flpProducts.Controls.Clear();
            this.query = "select * from ProductList Where ProductType = 'PcParts' and ProductCategory = 'Proccessor';";
            this.LoadProduct();
        }

        private void btnMotherboard_Click(object sender, EventArgs e)
        {
            this.flpProducts.Controls.Clear();
            this.query = "select * from ProductList Where ProductType = 'PcParts' and ProductCategory = 'Motherboard';";
            this.LoadProduct();
        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            this.flpProducts.Controls.Clear();
            this.query = "select * from ProductList Where ProductType = 'PcParts' and ProductCategory = 'RAM';";
            this.LoadProduct();
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            this.flpProducts.Controls.Clear();
            this.query = "select * from ProductList Where ProductType = 'PcParts' and ProductCategory = 'Storage';";
            this.LoadProduct();
        }

        private void btnPSU_Click(object sender, EventArgs e)
        {
            this.flpProducts.Controls.Clear();
            this.query = "select * from ProductList Where ProductType = 'PcParts' and ProductCategory = 'PSU';";
            this.LoadProduct();
        }
    }
}
