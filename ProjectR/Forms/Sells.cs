using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectR.Forms
{
    public partial class Sells : UserControl
    {
        internal DataAccess Da { get; set; }
        internal static string getTransactionID {  get; set; }

        public Sells()
        {
            InitializeComponent();
            Da= MainWindow.SqlDataAccess;
            this.PopulateGridView();
            
        }

        // Grid View Initialisation
        private void PopulateGridView2(string sql = "select * from ProductList;")
        {
            try
            {
                sql = $@"select ProductList.ProductName,
                        TransactionDetails.Quantity, TransactionDetails.UnitPrice
                        from TransactionDetails, ProductList  WHERE 
                        TransactionDetails.TransactionId = '{getTransactionID}' 
                        and ProductList.ProductId = TransactionDetails.ProductId;";

                var ds = this.Da.ExecuteQuery(sql);
                this.dgvMini.AutoGenerateColumns = false;
                this.dgvMini.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void PopulateGridView(string sql = "select * from TransactionList order by TimeAndDate;")
        {
            try
            {
            var ds = Da.ExecuteQuery(sql);
            this.dgvSellDetails.DataSource = ds.Tables[0];
            this.dgvSellDetails.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void dgvSellDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (this.dgvSellDetails.SelectedRows.Count==1)
                {
                    
                    this.lblTransactionIDValue.Text = this.dgvSellDetails.SelectedRows[0].Cells["TransactionID"].Value.ToString();
                    this.lblSalesmanIDValue.Text = this.dgvSellDetails.SelectedRows[0].Cells["SalesmanID"].Value.ToString();
                    this.lblCustomerIDValue.Text = this.dgvSellDetails.SelectedRows[0].Cells["CustomerID"].Value.ToString();
                    this.lblTimeAndDateValue.Text = this.dgvSellDetails.SelectedRows[0].Cells["TimeAndDate"].Value.ToString();
                    this.lblTotalAmountValue.Text = this.dgvSellDetails.SelectedRows[0].Cells["TotalAmount"].Value.ToString();

                    getTransactionID = this.lblTransactionIDValue.Text;

                    this.PopulateGridView2();
                }

                else if(this.dgvSellDetails.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Select a single row");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message);
            }
        }

        private void ClearAll()
        {
            this.lblTransactionIDValue.Text = "";
            this.lblSalesmanIDValue.Text = "";
            this.lblCustomerIDValue.Text = "";
            this.lblTimeAndDateValue.Text = "";
            this.lblTotalAmountValue.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSearchSellers.Text = "Search Transactios...";
            this.ClearAll();
            this.PopulateGridView();
            this.dgvSellDetails.ClearSelection();
            this.txtSearchSellers.Text = "Search Transactios...";

            try
            {
                var ds = this.Da.ExecuteQuery("select * from TransactionList where TransactionId = '' ");
                this.dgvMini.DataSource = ds.Tables[0];
            }
            catch { }
        }

        private void Sells_Load(object sender, EventArgs e)
        {
            this.dgvSellDetails.ClearSelection();
        }

        

        private void txtSearchSellers_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchSellers.Text == "")
            {
                this.txtSearchSellers.Text = "Search Transactios...";
                this.PopulateGridView();
                this.dgvSellDetails.ClearSelection();
            }
        }

        private void txtSearchSellers_Click(object sender, EventArgs e)
        {
            if (this.txtSearchSellers.Text == "Search Transactios...")
            {
                this.txtSearchSellers.Text = "";
                this.PopulateGridView();
                this.dgvSellDetails.ClearSelection();

            }
        }

        private void txtSearchSellers_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from TransactionList where TransactionID LIKE '%" + this.txtSearchSellers.Text + "%' OR SalesmanID LIKE '%" + this.txtSearchSellers.Text + "%' OR CustomerID LIKE '" + this.txtSearchSellers.Text + "';";
            this.PopulateGridView(sql);
            
        }
    }
}
