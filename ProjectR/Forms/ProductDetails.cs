using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectR.Forms
{
    public partial class ProductDetails : UserControl
    {
        internal DataAccess Da {  get; set; }
        private static string ProductId {  get; set; }

        public ProductDetails()
        {
            InitializeComponent();
            Da=new DataAccess();
        }

        
        public ProductDetails(string b) : this()
        {
            ProductId = b;
            ProductId = "P-001";
            string sql = "select * from ProductList where ProductId='"+ProductId+"';";
            var ds = Da.ExecuteQuery(sql);
            this.lblProductCategoryValue.Text = ds.Tables[0].Rows[0][3].ToString();
            this.lblProductNameValue.Text = ds.Tables[0].Rows[0][1].ToString();
            this.lblProductModelValue.Text = ds.Tables[0].Rows[0][2].ToString();
            this.lblProductStocksValue.Text = ds.Tables[0].Rows[0][5].ToString();
            this.btnProductCost.Text = ds.Tables[0].Rows[0][4].ToString()+" BDT";
        }
    }
}
