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
        internal Form MainWindowF { get; set; }
        internal DataAccess Da { get; set; }

        private static bool txtSearchProductsClick = true;

        public ProductList()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
            this.AutoIdGenerate();
        }
        public ProductList(Form a) : this()
        {
            this.MainWindowF = a;
        }

        // Grid View Initialisation
        private void PopulateGridView(string sql = "select * from ProductList;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvProductList.AutoGenerateColumns = false;
                this.dgvProductList.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Opps Error : " + exc.Message);
            }
            
            this.ClearAll();
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
            var sql = $"select * from ProductList where ProductName like '{this.txtSearchProducts.Text}%';";
            this.PopulateGridView(sql);
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
                var sql = "INSERT INTO ProductList " +"(ProductId, ProductName, ProductModel, ProductCategory, ProductPrice, ProductStock) " +"VALUES ('" + txtProductId.Text + "', '" + txtProductName.Text + "', '" + txtProductModel.Text + "', '" + cmbProductCategory.Text + "', " + txtProductPrice.Text + ", " + txtProductStock.Text + ");";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Product Added");
                else
                    MessageBox.Show("Product Was Not Added");

                this.ClearAll();
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Product Was NOT Added: " + exc.Message);
            }
        }

        // Clear All Texts
        private void ClearAll()
        {
            // DML Text Box's
            this.txtProductId.Clear();
            this.txtProductName.Clear();
            this.txtProductModel.Clear();
            //this.cmbProductCategory.SelectedIndex = -1;
            this.cmbProductCategory.Text = "";
            this.txtProductPrice.Clear();
            this.txtProductStock.Clear(); 
            
            //Clears Search Bar
            this.txtSearchProducts.Text = "";

            this.dgvProductList.ClearSelection();
            this.AutoIdGenerate();
        }

        // Validation [[CAN NOT BE EMPTY]]
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtProductId.Text) || string.IsNullOrEmpty(this.txtProductName.Text) ||
                string.IsNullOrEmpty(this.txtProductPrice.Text) || string.IsNullOrEmpty(this.txtProductModel.Text) ||
                string.IsNullOrEmpty(this.cmbProductCategory.Text) || string.IsNullOrEmpty(this.txtProductStock.Text))
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
                var query = "select * from ProductList where ProductId ='" + this.txtProductId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = @"UPDATE ProductList
                    SET ProductName = '" + this.txtProductName.Text + @"',
                        ProductModel = '" + this.txtProductModel.Text + @"',
                        ProductCategory = '" + this.cmbProductCategory.Text + @"',
                        ProductPrice = " + this.txtProductPrice.Text + @",
                        ProductStock = " + this.txtProductStock.Text + @"
                    WHERE ProductId = '" + this.txtProductId.Text + "';";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("PRODUCT Data UPDATED");
                    else
                        MessageBox.Show("PRODUCT DATA WAS NOT UPDATED");

                    this.PopulateGridView();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("DATA COULD NOT BE UPDATED!" + exc.Message);
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
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvProductList.CurrentRow.Cells[0].Value.ToString();
                var title = this.dgvProductList.CurrentRow.Cells[1].Value.ToString();

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
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            this.dgvProductList.ClearSelection();

        }
    }
}
