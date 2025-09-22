using ProjectR.Forms.ProductTypes;
using ProjectR.Forms.ProductTypes.ProductsCards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectR.Forms
{
    public partial class HomePage : UserControl
    {
        internal static bool SearchBoxClick = true;
        internal static Panel pnlProductsP {  get; set; }
        internal static DataGridView dgvTempCartP { get; set; }

        internal AllProducts allProducts {  get; set; }
        internal Games games {  get; set; }
        internal Laptops laptops { get; set; }
        internal PcParts pcParts { get; set; }
        internal static string SearchString { get; set; }
        private static string storeProductPageName {  get; set; }

        public HomePage()
        {
            InitializeComponent();
            SearchString = this.txtSearchProducts.Text;
            storeProductPageName = "AllProduct";
            dgvTempCartP = this.dgvTempCart;

            pnlProductsP = this.pnlProducts;
            this.PopulateGridView("select * from TempCart;");
        }

        private void btnGames_MouseHover(object sender, EventArgs e)
        {
            this.btnGames.FlatAppearance.BorderSize = 1;
        }

        private void btnGames_MouseLeave(object sender, EventArgs e)
        {
            this.btnGames.FlatAppearance.BorderSize = 0;
        }

        private void btnLaptops_MouseHover(object sender, EventArgs e)
        {
            this.btnLaptops.FlatAppearance.BorderSize = 1;
        }

        private void btnLaptops_MouseLeave(object sender, EventArgs e)
        {
            this.btnLaptops.FlatAppearance.BorderSize = 0;
        }

        private void btnPcParts_MouseHover(object sender, EventArgs e)
        {
            this.btnPcParts.FlatAppearance.BorderSize = 1;
        }

        private void btnPcParts_MouseLeave(object sender, EventArgs e)
        {
            this.btnPcParts.FlatAppearance.BorderSize = 0;
        }

        private void showUserControl(UserControl NextPage)
        {
            NextPage.Dock = DockStyle.Fill;
            this.pnlProducts.Controls.Clear();
            this.pnlProducts.Controls.Add(NextPage);
            NextPage.Show();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            this.games = new Games();
            showUserControl(this.games);
            storeProductPageName = "Games";
        }

        private void btnLaptops_Click(object sender, EventArgs e)
        {
            this.laptops = new Laptops();
            showUserControl(this.laptops);
            storeProductPageName = "Laptops";
        }

        private void btnPcParts_Click(object sender, EventArgs e)
        {
            this.pcParts = new PcParts();
            showUserControl(this.pcParts);
            storeProductPageName = "PcParts";
        }

        private void Search_TextChanged()
        {
            if (storeProductPageName == "Games")
            {
                string search = $@"select * from ProductList Where ProductType = 'Games' and (ProductId LIKE '{txtSearchProducts.Text}%' or ProductName LIKE '{txtSearchProducts.Text}%');";
                this.games = new Games(search);
                showUserControl(this.games);
            }
            else if (storeProductPageName == "Laptops")
            {
                string search = $@"select * from ProductList Where ProductType = 'Laptop' and (ProductId LIKE '{txtSearchProducts.Text}%' or ProductName LIKE '{txtSearchProducts.Text}%');";
                this.laptops = new Laptops(search);
                showUserControl(this.laptops);
            }
            else if (storeProductPageName == "PcParts")
            {
                this.pcParts = new PcParts();
                showUserControl(this.pcParts);
            }
            else
            {
                string search = $@"select * from ProductList Where ProductId LIKE '{txtSearchProducts.Text}%' or ProductName LIKE '{txtSearchProducts.Text}%';";
                this.allProducts = new AllProducts(search);
                showUserControl(this.allProducts);
            }
        }

        // Search Box
        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            this.Search_TextChanged();
        }

        // Grid View Initialisation
        private void PopulateGridView(string sql = "select * from TempCart;")
        {
            try
            {
                var ds = MainWindow.SqlDataAccess.ExecuteQuery(sql);
                dgvTempCartP.AutoGenerateColumns = false;
                dgvTempCartP.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (this.dgvTempCart.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a row first to delete.");
                return;
            }
            var id = this.dgvTempCart.CurrentRow.Cells["colProductId"].Value.ToString();
            var sql = "delete from TempCart where ProductId = '" + id + "';";
            MainWindow.SqlDataAccess.ExecuteDMLQuery(sql);
            this.PopulateGridView();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvTempCartP.Rows.Count == 0)
            {
                return;
            }

            Checkout NextPage = new Checkout();
            NextPage.Dock = DockStyle.Fill;
            MainWindow.MainWindowPanel.Controls.Clear();
            MainWindow.MainWindowPanel.Controls.Add(NextPage);
            NextPage.Show();
        }

        private void txtSearchProducts_Click(object sender, EventArgs e)
        {
            if (SearchBoxClick)
            {
                this.txtSearchProducts.Text = "";
                SearchBoxClick = false;
            }
        }

        private void txtSearchProducts_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchProducts.Text == "")
            {
                this.txtSearchProducts.Text = "Search by Product ID or Name";
                SearchBoxClick = true;

                this.allProducts = new AllProducts();
                showUserControl(this.allProducts);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.pnlProductType.Dock = DockStyle.Fill;
            pnlProductsP.Controls.Clear();
            pnlProductsP.Controls.Add(this.pnlProductType);
            storeProductPageName = "AllProduct";
        }

        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtQuantity.Text == "0")
                {
                    MessageBox.Show("Quantity can not be Zero");
                    return;
                }
                if (this.dgvTempCart.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to change quantity.");
                    return;
                }

                var row = dgvTempCart.CurrentRow;
                string productId = row.Cells["colProductId"].Value.ToString();
                int unitPrice = Convert.ToInt32(row.Cells["colProductPriceHome"].Value);
                int newQuantity = Convert.ToInt32(this.txtQuantity.Text);

                string sql2 = $"select * from ProductList where ProductId = '{productId}'";
                var dt = MainWindow.SqlDataAccess.ExecuteQueryTable(sql2);

                if (newQuantity > Convert.ToInt32(dt.Rows[0][5]) || Convert.ToInt32(dt.Rows[0][5]) == 0)
                {
                    MessageBox.Show("Can not add to cart due to quantity is higher than Stock value");
                    return;
                }

                int newTotalAmount = unitPrice * newQuantity;

                string updateSql = $"UPDATE TempCart SET ProductQuantity = {newQuantity}, TotalAmount = {newTotalAmount} WHERE ProductId = '{productId}'";
                MainWindow.SqlDataAccess.ExecuteDMLQuery(updateSql);

                PopulateGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating quantity: {ex.Message}");
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
