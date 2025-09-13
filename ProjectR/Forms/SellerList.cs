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
        internal Form MainWindowF { get; set; }
        internal DataAccess Da { get; set; }


        public SellerList()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();

        }
        public SellerList(Form a) : this()
        {
            this.MainWindowF = a;
        }

        // Grid View Initialisation
        private void PopulateGridView(string sql = "select UserList.UserName, UserList.UserId, UserList.UserPassword, UserList.UserDOB, UserList.UserPhone, UserList.UserNID, RoleList.Role from UserList INNER JOIN RoleList on UserList.UserId = RoleList.UserId")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvSellerList.AutoGenerateColumns = false;
                this.dgvSellerList.DataSource = ds.Tables[0];
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

        // Add User
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("PLEASE FILL ALL THE INFORMATIONS");
                    return;
                }
                var sql = $"INSERT INTO UserList (UserId, UserPassword,UserName,UserDOB,UserPhone,UserNID) VALUES ('{this.txtUserId.Text}','{this.txtUserPassword.Text}','{this.txtUserName.Text}','{this.dtpDOB.Text}','{this.txtUserPhone.Text}','{this.txtUserNID.Text}');";
                var count = this.Da.ExecuteDMLQuery(sql);
                var sql2 = $"INSERT INTO RoleList (UserId, Role) VALUES ('{this.txtUserId.Text}','{this.cmbUserRole.Text}');";
                var count2 = this.Da.ExecuteDMLQuery(sql2);

                if (count == 1 && count2 == 1)
                    MessageBox.Show("New Member Added");
                else
                    MessageBox.Show("Member Was Not Added");

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
            this.txtUserName.Text = this.dgvSellerList.CurrentRow.Cells["colUsername"].Value.ToString();
            this.txtUserPassword.Text = this.dgvSellerList.CurrentRow.Cells["colUserPassword"].Value.ToString() ;
            this.dtpDOB.Text = this.dgvSellerList.CurrentRow.Cells["colUserDOB"].Value.ToString();
            this.txtUserPhone.Text = this.dgvSellerList.CurrentRow.Cells["colUserPhone"].Value.ToString();
            this.txtUserNID.Text = this.dgvSellerList.CurrentRow.Cells["colUserNID"].Value.ToString();
            this.cmbUserRole.Text = this.dgvSellerList.CurrentRow.Cells["colUserRole"].Value.ToString();
        }

        // Update User
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("PLEASE FILL ALL INFORMATION");
                    return;
                }
                var sql = $"update RoleList set Role = '{this.cmbUserRole.Text}' where UserId = '{this.txtUserId.Text}';";
                var count = this.Da.ExecuteDMLQuery(sql);
                var sql2 = $"update UserList set UserName = '{this.txtUserName.Text}', UserPassword = '{this.txtUserPassword.Text}', UserDOB = '{this.dtpDOB.Text}', UserPhone = '{this.txtUserPhone.Text}', UserNID ='{this.txtUserNID.Text}' where UserId = '{this.txtUserId.Text}';";
                var count2 = this.Da.ExecuteDMLQuery(sql2);

                if (count == 1 && count2 == 1)
                    MessageBox.Show("Member Information Updated");
                else
                    MessageBox.Show("Member Information was NOT updated");

                this.PopulateGridView();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        // Delete User
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
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
    }
}
