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
        //internal string ProductId { get; set; }
        internal string Productname { get; set; }
        internal string ProductPrice { get; set; }

        public ProductDetails()
        {
            InitializeComponent();
            Da = MainWindow.SqlDataAccess;           
        }

        
        public ProductDetails(string b) : this()
        {
            ProductId = b;
            string sql = "select * from ProductList where ProductId='"+ProductId+"';";
            var ds = Da.ExecuteQuery(sql);
            this.lblProductCategoryValue.Text = ds.Tables[0].Rows[0][3].ToString();
            this.lblProductNameValue.Text = ds.Tables[0].Rows[0][1].ToString();
            this.lblProductModelValue.Text = ds.Tables[0].Rows[0][2].ToString();
            this.lblProductStocksValue.Text = ds.Tables[0].Rows[0][5].ToString();
            this.lblProductAmount.Text = ds.Tables[0].Rows[0][4].ToString()+" BDT";
            this.ptbProductPicture.Image = Image.FromFile(ds.Tables[0].Rows[0][8].ToString());
            this.lblProductDescriptionValue.Text = ds.Tables[0].Rows[0][7].ToString();
            this.Productname = this.lblProductNameValue.Text;
            this.ProductPrice = ds.Tables[0].Rows[0][4].ToString();
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
                HomePage.dgvTempCartP.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        // Add Method
        private void AddItem()
        {
           try
            {
                string sql = $"insert into TempCart VALUES ('{ProductId}','{Productname}',1, {ProductPrice} , {ProductPrice}) ;";
                string sql2 = $"select * from TempCart where ProductId = '{ProductId}'";
                var dt = MainWindow.SqlDataAccess.ExecuteQueryTable(sql2);

                if (dt.Rows.Count == 1)
                {
                    int quantity = Convert.ToInt32(dt.Rows[0][2]);
                    quantity += 1;
                    int TotalAmount = Convert.ToInt32(ProductPrice) * quantity;

                    string sql3 = $"UPDATE TempCart SET ProductQuantity = {quantity}, TotalAmount = {TotalAmount} where ProductId = '{ProductId}'";
                    MainWindow.SqlDataAccess.ExecuteDMLQuery(sql3);
                    return;
                }
                MainWindow.SqlDataAccess.ExecuteDMLQuery(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            this.AddItem();
            // this.ClearAll();
            this.PopulateGridView();
        }
    }
}
