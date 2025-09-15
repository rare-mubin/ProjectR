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
    public partial class ProductList : UserControl
    {
        internal DataAccess Da { get; set; }

        private static bool txtSearchProductsClick = true;

        public ProductList()
        {
            InitializeComponent();
            this.Da = new DataAccess();

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
                var sql = $"INSERT INTO ProductList (ProductId, ProductName, ProductModel, ProductCategory, ProductPrice, ProductStock, ProductType, ProductDescription) VALUES ('{this.txtProductId.Text}','{this.txtProductName.Text}' , '{this.txtProductModel.Text}','{this.cmbProductCategory.Text}',{this.txtProductPrice.Text},{this.txtProductStock.Text},'{this.txtProductType.Text}','{this.txtProductDescription.Text}');";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Product Added");
                else
                    MessageBox.Show("Product Was Not Added");

                this.ClearAll();
                this.PopulateGridView();
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
            this.txtProductType.Clear();
            this.txtProductDescription.Clear();
            this.dgvProductList.ClearSelection();

            this.AutoIdGenerate();
        }

        // Validation [[CAN NOT BE EMPTY]]
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtProductId.Text) || string.IsNullOrEmpty(this.txtProductName.Text) ||
                string.IsNullOrEmpty(this.txtProductPrice.Text) || string.IsNullOrEmpty(this.txtProductModel.Text) ||
                string.IsNullOrEmpty(this.cmbProductCategory.Text) || string.IsNullOrEmpty(this.txtProductStock.Text) ||
                string.IsNullOrEmpty(this.txtProductType.Text)|| string.IsNullOrEmpty(this.txtProductDescription.Text))
                return false;
            else
                return true;
        }

        // Update Product Button
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
           try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("PLEASE FILL ALL INFORMATION");
                    return;
                }

                // Correct column name
                var query = $"select * from ProductList where ProductId ='{this.txtProductId.Text}';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = $"Update ProductList SET ProductName = '{this.txtProductName.Text}', ProductModel = '{this.txtProductModel.Text}', ProductCategory = '{this.cmbProductCategory.Text}',ProductPrice = '{this.txtProductPrice.Text}', ProductStock = '{this.txtProductStock.Text}', ProductType = '{this.txtProductType.Text}', ProductDescription = '{this.txtProductDescription.Text}' WHERE ProductId = '{this.txtProductId.Text}';";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Product Data Updated");
                    else
                        MessageBox.Show("Product Data was not Updated");

                    this.PopulateGridView();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

      
        // Selectin To Update Information
        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvProductList.CurrentRow == null)
                return;
            this.txtProductId.Text = this.dgvProductList.CurrentRow.Cells["colProductId"].Value.ToString();
            this.txtProductName.Text = this.dgvProductList.CurrentRow.Cells["colProductName"].Value.ToString();
            this.txtProductModel.Text = this.dgvProductList.CurrentRow.Cells["colProductModel"].Value.ToString();
            this.cmbProductCategory.Text = this.dgvProductList.CurrentRow.Cells["colProductCategory"].Value.ToString();
            this.txtProductPrice.Text = this.dgvProductList.CurrentRow.Cells["colProductPrice"].Value.ToString();
            this.txtProductStock.Text = this.dgvProductList.CurrentRow.Cells["colProductStock"].Value.ToString();
            this.txtProductType.Text = this.dgvProductList.CurrentRow.Cells["colProductType"].Value.ToString();
            this.txtProductDescription.Text = this.dgvProductList.CurrentRow.Cells["colProductDescription"].Value.ToString();
            this.AutoIdGenerate();
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
    }
}
