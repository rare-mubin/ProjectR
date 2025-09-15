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
        internal Form MainWindowF { get; set; }
        internal DataAccess Da {  get; set; }

        public Sells()
        {
            InitializeComponent();
            string sql = "select * from TransactionList;";
            Da=new DataAccess();
            this.PopulateGridView();
            
        }

        public void PopulateGridView(string sql = "select * from TransactionList;")
        {
            var ds = Da.ExecuteQuery(sql);
            this.dgvSellDetails.DataSource = ds.Tables[0];
            this.dgvSellDetails.AutoGenerateColumns = false;
        }

        public Sells(Form a) : this()
        {
            this.MainWindowF = a;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lblTransactionIDValue.Text = "";
            this.lblSalesmanIDValue.Text = "";
            this.lblCustomerIDValue.Text = "";
            this.lblTimeAndDateValue.Text = "";
            this.lblTotalAmountValue.Text = "";
        }
    }
}
