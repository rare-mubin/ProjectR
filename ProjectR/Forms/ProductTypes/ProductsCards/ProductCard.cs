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
        public ProductCard()
        {
            InitializeComponent();
        }
        public ProductCard(string productId,string productName, string productCategory, string productType , string productPrice) : this()
        {
            this.lblProductName.Text = productName;
            this.lblProductCategory.Text = productCategory;
            this.lblProductType.Text = productType;
            this.lblPrice.Text = productPrice;
            this.ProductId = productId;
        }

        private void pnlCard_Click(object sender, EventArgs e)
        {
            ProductDetails details = new ProductDetails(ProductId);
            details.Dock = DockStyle.Fill;
            HomePage.pnlProductsP.Controls.Clear();
            HomePage.pnlProductsP.Controls.Add(details);
            details.Show();
        }
    }
}
