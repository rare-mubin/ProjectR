using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectR.Forms.ProductTypes.ProductsCards;

namespace ProjectR.Forms.ProductTypes
{
    public partial class Games : UserControl
    {
        internal DataAccess Da { get; set; }
        internal string productId { get; set; }
        internal string productName { get; set; } 
        internal string productType { get; set; }
        internal string productCategory {  get; set; }
        internal string productPrice { get; set; }
        internal string picturePath { get; set; }

        public Games()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void Games_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from ProductList;";
                var ProductsTable = this.Da.ExecuteQueryTable(query);
                
                for (int Counter = 0; Counter < ProductsTable.Rows.Count; Counter++)
                {
                    this.productId = ProductsTable.Rows[Counter][0].ToString();
                    this.productName = ProductsTable.Rows[Counter][1].ToString();
                    this.productCategory = ProductsTable.Rows[Counter][3].ToString();
                    this.productType = ProductsTable.Rows[Counter][2].ToString();
                    this.productPrice = ProductsTable.Rows[Counter][4].ToString();
                    this.picturePath = ProductsTable.Rows[Counter][8].ToString();

                    ProductCard card = new ProductCard(this.productId, this.productName, this.productCategory, this.productType, this.productPrice ,this.picturePath);

                    this.flpProducts.Controls.Add(card);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }

        }
    }
}
