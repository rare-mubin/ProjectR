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
        internal static Panel pnlProductsP {  get; set; }
        //internal DataAccess Da {  get; set; }
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
            this.games = new Games();
            this.laptops = new Laptops();
            this.pcParts = new PcParts();
            dgvTempCartP = this.dgvTempCart;
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            pnlProductsP = this.pnlProducts;

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
            showUserControl(this.games);
            storeProductPageName = "Games";
        }

        private void btnLaptops_Click(object sender, EventArgs e)
        {
            showUserControl(this.laptops);
            storeProductPageName = "Laptops";
        }

        private void btnPcParts_Click(object sender, EventArgs e)
        {
            showUserControl(this.pcParts);
            storeProductPageName = "PcParts";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnlProductType.Dock = DockStyle.Fill;
            pnlProductsP.Controls.Clear();
            pnlProductsP.Controls.Add(this.pnlProductType);
            storeProductPageName = "AllProduct";
        }

       

        // Search Box
        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            if (storeProductPageName == "Games")
            {
                this.games = new Games();
                showUserControl(this.games);
            }
            else if (storeProductPageName == "Laptops")
            {
                this.laptops = new Laptops();
                showUserControl(this.laptops);
            }
            else if (storeProductPageName == "PcParts")
            {
                this.pcParts = new PcParts();
                showUserControl(this.pcParts);
            }
            else 
            {
                this.allProducts = new AllProducts();
                showUserControl(this.allProducts);
            }
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

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (this.dgvTempCart.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a row first to delete.");
                return;
            }
            var id = this.dgvTempCart.CurrentRow.Cells["colProductId"].Value.ToString();
            var sql = "delete from TempCart where ProductId = '" + id + "';";
            //var count = this.Da.ExecuteDMLQuery(sql);
            MainWindow.SqlDataAccess.ExecuteDMLQuery(sql);
            this.PopulateGridView();
            

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Checkout NextPage = new Checkout();
            NextPage.Dock = DockStyle.Fill;
            MainWindow.MainWindowPanel.Controls.Clear();
            MainWindow.MainWindowPanel.Controls.Add(NextPage);
            NextPage.Show();
        }
    }
}
