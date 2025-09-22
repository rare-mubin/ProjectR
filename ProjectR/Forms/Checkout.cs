using System;
using System.Data;
using System.Windows.Forms;

namespace ProjectR.Forms
{
    public partial class Checkout : UserControl
    {
        internal DataAccess Da;
        internal string ProductId { get; set; }
        internal string ProductQuantity { get; set; }
        internal string ProductPrice { get; set; }
        internal string UserId { get; set; }
        internal string MemberPhone { get; set; }
        internal string MemberPoint { get; set; }

        public Checkout()
        {
            InitializeComponent();
            Da = MainWindow.SqlDataAccess;

            this.UserId = MainWindow.LogInUser.Rows[0][0].ToString();
            this.AutoIdGenerate();
            this.LoadCartItems();
            this.PopulateGridView();
            this.UpdateTotalAmount();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Dock = DockStyle.Fill;
            MainWindow.MainWindowPanel.Controls.Clear();
            MainWindow.MainWindowPanel.Controls.Add(homePage);
            homePage.Show();
        }

        // Fetch Data from TempCart
        private void LoadCartItems()
        {
            try
            {
                this.lblSellerID.Text = $"Seller ID: {this.UserId}";
                this.MemberPhone = this.txtMemberPhone.Text.Trim();
                this.MemberPoint = this.txtMemberPoints.Text.Trim();
                this.UpdateTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cart: {ex.Message}");
            }
        }


        // Change Quantity Button Event
        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNewQuantity.Text == "0")
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
                string productId = row.Cells["colProductIdTemp"].Value.ToString();
                int unitPrice = Convert.ToInt32(row.Cells["colProductUnitPrice"].Value);

                int newQuantity = Convert.ToInt32(this.txtNewQuantity.Text);

                string sql2 = $"select * from ProductList where ProductId = '{productId}'";
                var dt = MainWindow.SqlDataAccess.ExecuteQueryTable(sql2);

                if (newQuantity > Convert.ToInt32(dt.Rows[0][5]) || Convert.ToInt32(dt.Rows[0][5]) == 0)
                {
                    MessageBox.Show("Can not add to cart due to quantity is higher than Stock value");
                    return;
                }

                int newTotalAmount = unitPrice * newQuantity;

                string updateSql = $"UPDATE TempCart SET ProductQuantity = {newQuantity}, TotalAmount = {newTotalAmount} WHERE ProductId = '{productId}'";
                Da.ExecuteDMLQuery(updateSql);

                PopulateGridView();
                UpdateTotalItems();
                UpdateTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating quantity: {ex.Message}");
            }

        }

        // Update Total Amount
        private void UpdateTotalAmount()
        {
            try
            {
                string sql = "SELECT SUM(TotalAmount) FROM TempCart;";
                var dt = Da.ExecuteQueryTable(sql);
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    this.lblTotalAmount.Text = $"Total Amount: {dt.Rows[0][0].ToString()}";
                }
                else
                {
                    this.lblTotalAmount.Text = $"Total Amount: 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total amount: {ex.Message}");
            }
        }

        // Auto Genarate Transaction Id
        private string AutoIdGenerate()
        {
            var query = "select max(TransactionId) from TransactionList;";
            var dt = this.Da.ExecuteQueryTable(query);
            if (dt.Rows[0][0] == DBNull.Value)
                return "T-001";

            var oldId = dt.Rows[0][0].ToString();
            var s = oldId.Split('-');
            var temp = Convert.ToInt32(s[1]);
            string newid = "T-" + (++temp).ToString("d3");
            this.lblGenerateTransitionID.Text = newid;
            return newid;

        }

        // Grid View Initialisation
        private void PopulateGridView(string sql = "select * from TempCart;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvTempCart.AutoGenerateColumns = false;
                this.dgvTempCart.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        // Redeem Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT SUM(TotalAmount) FROM TempCart;";
                var dt = Da.ExecuteQueryTable(sql);
                double totalAmount = Convert.ToDouble(dt.Rows[0][0]);

                double redeemPoints = Convert.ToDouble(this.txtMemberPoints.Text);


                double totalAfterDiscount = totalAmount - redeemPoints;
                if (totalAfterDiscount < 0) totalAfterDiscount = 0;

                lblTotaAfterDiscount.Text = totalAfterDiscount.ToString();
                this.lblDiscount.Text = $"Discount: {this.txtMemberPoints.Text}";
                this.RefreshCartUI();
                this.UpdateTotalAmount();
                this.UpdateTotalItems();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying discount: {ex.Message}");
            }
        }
        // Item Count
        private void UpdateTotalItems()
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM TempCart;";
                var dt = Da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                    int totalItems = Convert.ToInt32(dt.Rows[0][0]);
                    lblTotalItem.Text = $"Total Item :{totalItems.ToString()}";
                }
                else
                {
                    lblTotalItem.Text = "Total Item: 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error counting cart items: {ex.Message}");
            }
        }
        // Load
        private void Checkout_Load(object sender, EventArgs e)
        {
            try
            {
                this.UpdateTotalItems();
                this.AutoIdGenerate();
                this.dgvTempCart.ClearSelection();
                string sql = "SELECT SUM(TotalAmount) FROM TempCart;";
                var dt = Da.ExecuteQueryTable(sql);
                double totalAmount = Convert.ToDouble(dt.Rows[0][0]);
                this.lblTotaAfterDiscount.Text = $"{totalAmount} BDT";
            }
            catch { }
            
        }

        // Label Minupulations
        private void RefreshCartUI()
        {
            try
            {
                PopulateGridView();
                string countSql = "SELECT COUNT(*) FROM TempCart;";
                var dtCount = Da.ExecuteQueryTable(countSql);
                int totalItems = Convert.ToInt32(dtCount.Rows[0][0]);
                lblTotalItem.Text = totalItems.ToString();
                string sumSql = "SELECT SUM(TotalAmount) FROM TempCart;";
                var dtSum = Da.ExecuteQueryTable(sumSql);
                double totalAmount = dtSum.Rows[0][0] == DBNull.Value ? 0 : Convert.ToDouble(dtSum.Rows[0][0]);
                lblTotalAmount.Text = totalAmount.ToString();

                double redeemPoints = 0;
                double points = Convert.ToDouble(this.txtMemberPoints.Text);                
                    redeemPoints = points;

                double totalAfterDiscount = totalAmount - redeemPoints;
                if (totalAfterDiscount < 0)
                    totalAfterDiscount = 0;
                lblTotaAfterDiscount.Text = totalAfterDiscount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing cart: {ex.Message}");
            }
        }

        // Delte Button
        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvTempCart.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvTempCart.CurrentRow.Cells["colProductIdTemp"].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove Item", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;


                var sql = "delete from TempCart where ProductId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);



                if (count == 1)
                    MessageBox.Show(" Item has been removed from the list");
                else
                    MessageBox.Show("Item Has not been removed");

                this.RefreshCartUI();
                this.UpdateTotalAmount();
                this.UpdateTotalItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        // Confirm Button Helper Methods
        // Transaction list Update
        private void UpdateTransactionList(string transactionId, string memberPhone, double redeemPoints, string paymentMethod)
        {
            try
            {
                string sqlTotal = "SELECT SUM(TotalAmount) FROM TempCart;";
                var dtTotal = Da.ExecuteQueryTable(sqlTotal);
                double totalAmount = Convert.ToDouble(dtTotal.Rows[0][0]);
                double finalAmount = Math.Max(0, totalAmount - redeemPoints);
                string sql = $@"
                        INSERT INTO TransactionList 
                        (TransactionId, SalesmanId, CustomerId, TimeAndDate, TotalAmount, PaymentOption)
                        VALUES 
                        ('{transactionId}', '{UserId}', '{memberPhone}', GETDATE(), {finalAmount}, '{paymentMethod}');";
                Da.ExecuteDMLQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " +ex.Message);
            }

        }

        // Product list Update
        private void UpdateProductList()
        {
            try
            {
                string sql = "SELECT ProductId, ProductQuantity FROM TempCart";
                var dt = Da.ExecuteQueryTable(sql);

                int index = 0;
                while (index < dt.Rows.Count)
                {
                    DataRow row = dt.Rows[index];

                    string productId = row["ProductId"].ToString();
                    int quantity = Convert.ToInt32(row["ProductQuantity"]);

                   for(int i = 0; i< quantity;i++)
                    {

                        string sqlUpdate = $@"
                             UPDATE ProductList 
                             SET ProductStock = ProductStock - 1 
                             WHERE ProductId = '{productId}'";

                        Da.ExecuteDMLQuery(sqlUpdate);
                    }
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product list: {ex.Message}");
            }
        }

        // Transaction Detail Update
        private void UpdateTransactionDetails(string transactionId)
        {
            try
            {
                string sql = "SELECT ProductId, ProductQuantity, ProductUnitPrice FROM TempCart";
                var dt = Da.ExecuteQueryTable(sql);

                foreach (DataRow row in dt.Rows)
                {
                    string productId = row["ProductId"].ToString();
                    int quantity = Convert.ToInt32(row["ProductQuantity"]);
                    int unitPrice = Convert.ToInt32(row["ProductUnitPrice"]);
                    
                    string detailId = GenerateTransactionDetailId();
                    string insertSql = $@"
                                       INSERT INTO TransactionDetails
                                       (TransactionDetailId, TransactionId, ProductId, Quantity, UnitPrice)
                                       VALUES ('{detailId}', '{transactionId}', '{productId}', {quantity}, {unitPrice})";
                    Da.ExecuteDMLQuery(insertSql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating transaction details: {ex.Message}");
            }
        }
        // Transaction Details Id Auto Genarate
        private string GenerateTransactionDetailId()
        {
            string query = "SELECT MAX(TransactionDetailId) FROM TransactionDetails;";
            var dt = Da.ExecuteQueryTable(query);

            if (dt.Rows[0][0] == DBNull.Value)
                return "TD-001";

            var oldId = dt.Rows[0][0].ToString();
            var s = oldId.Split('-');
            var temp = Convert.ToInt32(s[1]);
            return "TD-" + (++temp).ToString("d3");
        }
        // Member list Update
        private void UpdateMemberList(string memberPhone, double redeemPoints, double finalAmount)
        {
            try
            {
                string sqlCheck = $"SELECT MemberPoints FROM MemberList WHERE MemberPhone = '{memberPhone}'";
                var dt = Da.ExecuteQueryTable(sqlCheck);

                if (dt.Rows.Count == 1)
                {
                    double currentPoints = Convert.ToDouble(dt.Rows[0]["MemberPoints"]);
                    double earnedPoints = Math.Floor(finalAmount / 100);
                    double newPoints = currentPoints - redeemPoints + earnedPoints;
                    if (newPoints < 0) newPoints = 0;
                    string sqlUpdate = $"UPDATE MemberList SET MemberPoints = {newPoints} WHERE MemberPhone = '{memberPhone}'";
                    Da.ExecuteDMLQuery(sqlUpdate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating member list: {ex.Message}");
            }
        }

        // Not Empty
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.cmbSelectPaymentMethod.Text) || string.IsNullOrEmpty(this.txtMemberPhone.Text) ||
                string.IsNullOrEmpty(this.txtMemberPoints.Text))
                return false;
            else
                return true;
        }


        // Confirm Transaction
        private void btnConfirmTransaction_Click(object sender, EventArgs e)
        {

            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please Fill All the Information");
                    return;
                }
                string transactionId = AutoIdGenerate();
                lblGenerateTransitionID.Text = transactionId;

                string memberPhone = txtMemberPhone.Text.Trim();
                double redeemPoints = 0;
                redeemPoints = Convert.ToDouble(txtMemberPoints.Text.Trim());
                string paymentMethod = this.cmbSelectPaymentMethod.Text.Trim();

                string sqlTotal = "SELECT SUM(TotalAmount) FROM TempCart;";
                var dtTotal = Da.ExecuteQueryTable(sqlTotal);
                double totalAmount = Convert.ToDouble(dtTotal.Rows[0][0]);
                double finalAmount = Math.Max(0, totalAmount - redeemPoints);

                UpdateTransactionList(transactionId, memberPhone, redeemPoints, paymentMethod);
                UpdateProductList();
                UpdateTransactionDetails(transactionId);
                UpdateMemberList(memberPhone, redeemPoints, finalAmount);

                Da.ExecuteDMLQuery("DELETE FROM TempCart;");
                RefreshCartUI();
                MessageBox.Show("Transaction completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error completing transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void txtMemberPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtMemberPhone.Text == "")
                {
                    return;
                }

                string sql = $"Select MemberPoints from MemberList WHERE MemberPhone = {this.txtMemberPhone.Text}";
                var dt = Da.ExecuteQueryTable(sql);
                if (dt.Rows.Count == 1)
                {
                    this.lblMembershipPoints.Text += dt.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }

        }

        private void txtNewQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
