using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectR.Forms
{
    public partial class SellerList : UserControl
    {
        internal DataAccess Da { get; set; }
        private static bool txtSearchSellersClick = true;

        public SellerList()
        {
            InitializeComponent();
            this.Da = MainWindow.SqlDataAccess;
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        // Grid View Initialisation
        private void PopulateGridView(string sql = "select UserList.UserName, UserList.UserId, UserList.UserPassword, UserList.UserDOB, UserList.UserPhone, UserList.UserNID, RoleList.Role from UserList INNER JOIN RoleList on UserList.UserId = RoleList.UserId")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvSellerList.AutoGenerateColumns = false;
                this.dgvSellerList.DataSource = ds.Tables[0];
                this.dgvSellerList.EnableHeadersVisualStyles = false;
                dgvSellerList.RowHeadersVisible = false;
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }

        }

        // Auto Generate Id
        private void AutoIdGenerate()
        {
            try
            {
                string role = this.cmbUserRole.Text;
                string prefix;
                if (role == "Admin")
                    prefix = "A-";
                else
                    prefix = "S-";

                var sql = "SELECT MAX(UserId) FROM UserList;";
                var dt = this.Da.ExecuteQueryTable(sql);

                if (dt.Rows[0][0] == DBNull.Value)
                {
                    this.txtUserId.Text = prefix + "001";
                    return;
                }

                var oldId = dt.Rows[0][0].ToString();   
                var s = oldId.Split('-');
                var temp = Convert.ToInt32(s[1]);       
                var newId = prefix + (++temp).ToString("D3");  

                this.txtUserId.Text = newId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        // Clear Method
        private void ClearAll()
        {
            this.txtUserName.Clear();
            this.txtUserPassword.Clear();
            this.dtpDOB.Value = DateTime.Now; 
            this.txtUserPhone.Clear();
            this.txtUserNID.Clear();
            this.cmbUserRole.SelectedIndex = -1; 
            this.dgvSellerList.ClearSelection();
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text) || string.IsNullOrEmpty(this.txtUserPassword.Text)
                || string.IsNullOrEmpty(this.dtpDOB.Text) || string.IsNullOrEmpty(this.txtUserPhone.Text)
                || string.IsNullOrEmpty(this.txtUserNID.Text) || string.IsNullOrEmpty(this.cmbUserRole.Text))
                return false;
            else
                return true;
        }

        // Save User
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtUserId.Text == "A-001")
                {
                    MessageBox.Show("This User Can not Be Updated");
                    return;
                }

                if (!this.IsValidToSave())
                {
                    MessageBox.Show("PLEASE FILL ALL INFORMATION");
                    return;
                }

                string userId = this.txtUserId.Text.Trim();

                // check if user exists
                string checkSql = $"SELECT * FROM UserList WHERE UserId = '{userId}';";
                var dt = this.Da.ExecuteQueryTable(checkSql);

                string sqlUser;
                string sqlRole;

                if (dt.Rows.Count == 1)
                {
                    // User exists → Update
                    sqlUser = $"UPDATE UserList SET UserName = '{this.txtUserName.Text}', UserPassword = '{this.txtUserPassword.Text}', UserDOB = '{this.dtpDOB.Text}', UserPhone = '{this.txtUserPhone.Text}', UserNID = '{this.txtUserNID.Text}' WHERE UserId = '{userId}';";
                    sqlRole = $"UPDATE RoleList SET Role = '{this.cmbUserRole.Text}' WHERE UserId = '{userId}';";
                }
                else
                {
                    // User does not exist → Insert
                    sqlUser = $"INSERT INTO UserList (UserId, UserPassword, UserName, UserDOB, UserPhone, UserNID) VALUES ('{userId}', '{this.txtUserPassword.Text}', '{this.txtUserName.Text}', '{this.dtpDOB.Text}', '{this.txtUserPhone.Text}', '{this.txtUserNID.Text}');";
                    sqlRole = $"INSERT INTO RoleList (UserId, Role) VALUES ('{userId}', '{this.cmbUserRole.Text}');";
                }

                var countUser = this.Da.ExecuteDMLQuery(sqlUser);
                var countRole = this.Da.ExecuteDMLQuery(sqlRole);

                if (countUser == 1 && countRole == 1)
                    MessageBox.Show("User Information Saved Successfully");
                else
                    MessageBox.Show("User Information could not be saved");

                this.ClearAll();
                this.PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void dgvSellerList_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.dgvSellerList.CurrentRow.Cells["colUserId"].Value.ToString();
            this.txtUserName.Text = this.dgvSellerList.CurrentRow.Cells["colUserName"].Value.ToString();
            this.txtUserPassword.Text = this.dgvSellerList.CurrentRow.Cells["colUserPassword"].Value.ToString() ;
            this.dtpDOB.Text = this.dgvSellerList.CurrentRow.Cells["colUserDOB"].Value.ToString();
            this.txtUserPhone.Text = this.dgvSellerList.CurrentRow.Cells["colUserPhone"].Value.ToString();
            this.txtUserNID.Text = this.dgvSellerList.CurrentRow.Cells["colUserNID"].Value.ToString();
            this.cmbUserRole.Text = this.dgvSellerList.CurrentRow.Cells["colUserRole"].Value.ToString();
        }

        // Clear User
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.AutoIdGenerate();
        }

        // Delete User
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvSellerList.CurrentRow.Cells["colUserId"].Value.ToString() == "A-001")
                {
                    MessageBox.Show("This User Can not Be Deleted");
                    return;
                }

                if (this.dgvSellerList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvSellerList.CurrentRow.Cells["colUserId"].Value.ToString();
                var title = this.dgvSellerList.CurrentRow.Cells["colUserName"].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + title + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = $"delete from UserList where UserId = '{id}';";
                var count = this.Da.ExecuteDMLQuery(sql);
                var sql2 = $"delete from RoleList where UserId = '{id}';";
                var count2 = this.Da.ExecuteDMLQuery(sql2);

                if (count == 1 && count2 == 1)
                    MessageBox.Show(title.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("User Has not been Removed");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }      

        private void SellerList_Load(object sender, EventArgs e)
        {
            this.dgvSellerList.ClearSelection();
            this.dgvSellerList.EnableHeadersVisualStyles = false;
            dgvSellerList.RowHeadersVisible = false;
        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoIdGenerate();
            txtUserId.ReadOnly = true;
        }

        // Search Box
        private void txtSearchSellers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = this.txtSearchSellers.Text.Trim();
                string sql = $"select u.UserId, u.UserName, u.UserDOB, u.UserPhone, u.UserNID, r.Role from UserList u inner join RoleList r on u.UserId = r.UserId where u.UserName like '{searchText}%' or u.UserId like '{searchText}%' or u.UserPhone like '{searchText}%' or r.Role like '{searchText}%';";
                this.PopulateGridView(sql);
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        // UI
        private void txtSearchSellers_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchSellers.Text == "")
            {
                this.txtSearchSellers.Text = "Search Users...";
                txtSearchSellersClick = true;
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

        // UI
        private void txtSearchSellers_Click(object sender, EventArgs e)
        {
            if (txtSearchSellersClick)
            {
                this.txtSearchSellers.Text = "";
                txtSearchSellersClick = false;
            }
        }

        private void txtUserPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
