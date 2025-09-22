using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectR.Forms
{
    public partial class ProductList : UserControl
    {
        internal DataAccess Da { get; set; }

        internal static string destinationFilePath { get; set; }

        private static bool txtSearchProductsClick = true;

        public ProductList()
        {
            InitializeComponent();
            this.Da = MainWindow.SqlDataAccess;

            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        // Grid View Initialisation
        private void PopulateGridView(string sql = "select * from ProductList;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvProductList.AutoGenerateColumns = false;
                this.dgvProductList.DataSource = ds.Tables[0];                
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        // UI
        private void txtSearchProducts_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchProducts.Text == "")
            {
                this.txtSearchProducts.Text = "Search products";
                txtSearchProductsClick = true;
            }
            try
            {
                this.PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        //UI
        private void txtSearchProducts_Click(object sender, EventArgs e)
        {
            if (txtSearchProductsClick)
            {
                this.txtSearchProducts.Text = "";
                txtSearchProductsClick = false;
            }
        }

        // Search Box
        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = this.txtSearchProducts.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    this.PopulateGridView();
                    return;
                }

                string sql = $"SELECT * FROM ProductList WHERE ProductName LIKE '%{searchText}%' OR ProductModel LIKE '%{searchText}%' OR ProductId LIKE '%{searchText}%';";
                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }


        //Copy file 
        private void CopyFIle()
        {
            string sourceFilePath = this.txtFilePath.Text;
            string fileName = $"{this.txtProductId.Text}.png";
            destinationFilePath = Path.Combine(@"..\..\ProductImage", fileName);

            string destinationDirectory = Path.GetDirectoryName(destinationFilePath);
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            try
            {
                File.Copy(sourceFilePath, destinationFilePath, true);
            }
            catch (Exception ex)
            {
            }
        }

        // Add Product Button
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("PLEASE FILL ALL INFORMATION");
                    return;
                }

                string query = $"SELECT * FROM ProductList WHERE ProductId ='{this.txtProductId.Text}';";
                DataTable dt = Da.ExecuteQueryTable(query);
                if(dt.Rows.Count == 1)
                {
                  
                    this.CopyFIle();
                   
                    var sql = $"Update ProductList SET ProductName = '{this.txtProductName.Text}', ProductModel = '{this.txtProductModel.Text}', ProductCategory = '{this.cmbProductCategory.Text}',ProductPrice = {this.txtProductPrice.Text}, ProductStock = {this.txtProductStock.Text}, ProductType = '{this.cmbProductType.Text}', ProductDescription = '{this.txtProductDescription.Text}',ProductImagePath = '{destinationFilePath}' WHERE ProductId = '{this.txtProductId.Text}';";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Product Data Updated");
                    else
                        MessageBox.Show("Product Data was not Updated");

                    this.PopulateGridView();                   

                }

               else
                {
                    this.CopyFIle();

                    var sql2 = $"INSERT INTO ProductList (ProductId, ProductName, ProductModel, ProductCategory, ProductPrice, ProductStock, ProductType, ProductDescription,ProductImagePath) VALUES ('{this.txtProductId.Text}','{this.txtProductName.Text}' , '{this.txtProductModel.Text}','{this.cmbProductCategory.Text}',{this.txtProductPrice.Text},{this.txtProductStock.Text},'{this.cmbProductType.Text}','{this.txtProductDescription.Text}','{destinationFilePath}');";
                    var count2 = this.Da.ExecuteDMLQuery(sql2);

                    if (count2 == 1)
                        MessageBox.Show("Product Added");
                    else
                        MessageBox.Show("Product Was Not Added");

                    this.ClearAll();
                    this.PopulateGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        // Clear All Texts
        private void ClearAll()
        {
            this.txtProductId.Clear();
            this.txtProductName.Clear();
            this.txtProductModel.Clear();
            this.cmbProductCategory.SelectedIndex = -1;
            this.txtProductPrice.Clear();
            this.txtProductStock.Clear();
            this.cmbProductType.SelectedIndex = -1;
            this.txtProductDescription.Clear();
            this.txtFilePath.Clear();
            this.dgvProductList.ClearSelection();

            this.AutoIdGenerate();
        }

        // Validation [[CAN NOT BE EMPTY]]
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtProductId.Text) || string.IsNullOrEmpty(this.txtProductName.Text) ||
                string.IsNullOrEmpty(this.txtProductPrice.Text) || string.IsNullOrEmpty(this.txtProductModel.Text) ||
                string.IsNullOrEmpty(this.cmbProductCategory.Text) || string.IsNullOrEmpty(this.txtProductStock.Text) ||
                string.IsNullOrEmpty(this.cmbProductType.Text)|| string.IsNullOrEmpty(this.txtProductDescription.Text)||
                string.IsNullOrEmpty(this.txtFilePath.Text))
                return false;
            else
                return true;
        }

        // Clear All Button Added
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
           try
            {
                this.ClearAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

      
        // Selectin To Update Information
        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductId.Text = this.dgvProductList.CurrentRow.Cells["colProductId"].Value.ToString();
            this.txtProductName.Text = this.dgvProductList.CurrentRow.Cells["colProductName"].Value.ToString();
            this.txtProductModel.Text = this.dgvProductList.CurrentRow.Cells["colProductModel"].Value.ToString();
            this.cmbProductCategory.Text = this.dgvProductList.CurrentRow.Cells["colProductCategory"].Value.ToString();
            this.txtProductPrice.Text = this.dgvProductList.CurrentRow.Cells["colProductPrice"].Value.ToString();
            this.txtProductStock.Text = this.dgvProductList.CurrentRow.Cells["colProductStock"].Value.ToString();
            this.cmbProductType.Text = this.dgvProductList.CurrentRow.Cells["colProductType"].Value.ToString();
            this.txtProductDescription.Text = this.dgvProductList.CurrentRow.Cells["colProductDescription"].Value.ToString();
            this.txtFilePath.Text = this.dgvProductList.CurrentRow.Cells["colFilePath"].Value.ToString();
        }

        // Auto Generate Id
        private void AutoIdGenerate()
        {
            var query = "select max(ProductId) from ProductList;";
            var dt = this.Da.ExecuteQueryTable(query);
            if (dt.Rows[0][0] == DBNull.Value)
            {
                this.txtProductId.Text = "P-001";
                return;
            }
            var oldId = dt.Rows[0][0].ToString();
            var s = oldId.Split('-');
            var temp = Convert.ToInt32(s[1]);
            var newId = "P-" + (++temp).ToString("d3");
            this.txtProductId.Text = newId;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProductList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvProductList.CurrentRow.Cells["colProductId"].Value.ToString();
                var title = this.dgvProductList.CurrentRow.Cells["colProductName"].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + title + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                File.Delete($@"..\..\ProductImage\{id}.png");

                var sql = "delete from ProductList where ProductId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                

                if (count == 1)
                    MessageBox.Show(title.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            this.dgvProductList.ClearSelection();            
        }

        private void btnChosePicture_Click(object sender, EventArgs e)
        {
            this.ofdChoseFile.ShowDialog();
        }

        private void ofdChoseFile_FileOk(object sender, CancelEventArgs e)
        {
            this.txtFilePath.Text = this.ofdChoseFile.FileName;
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
