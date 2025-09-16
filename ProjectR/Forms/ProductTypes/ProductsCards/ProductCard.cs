using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectR.Forms.ProductTypes.ProductsCards
{
    public partial class ProductCard : UserControl
    {
        internal string ProductId {  get; set; }
        internal string ProductName {  get; set; }
        internal string ProductPrice {  get; set; }

        public ProductCard()
        {
            InitializeComponent();
        }
        public ProductCard(string productId,string productName, string productCategory, string productType , string productPrice ,string picturePath) : this()
        {
            this.lblProductName.Text = productName;
            this.lblProductCategory.Text = productCategory;
            this.lblProductType.Text = productType;
            this.lblPrice.Text = productPrice;
            this.ProductId = productId;
            this.ptbProductImage.Image = Image.FromFile(picturePath);
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }

        private void pnlCard_Click(object sender, EventArgs e)
        {
            ProductDetails details = new ProductDetails(ProductId);
            details.Dock = DockStyle.Fill;
            HomePage.pnlProductsP.Controls.Clear();
            HomePage.pnlProductsP.Controls.Add(details);
            details.Show();
        }

        // Grid View Initialisation
        private void PopulateGridView(string sql = "select * from TempCart;")
        {
            try
            {
                var ds = MainWindow.SqlDataAccess.ExecuteQuery(sql);
                HomePage.dgvTempCartP.AutoGenerateColumns = false;
                HomePage.dgvTempCartP.DataSource = ds.Tables[0];
                //this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }



        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
    }
}
