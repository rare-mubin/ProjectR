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
            }
            catch (Exception exc)
            {
                MessageBox.Show("Opps Error : " + exc.Message);
            }

            this.ClearAll();
        }
        // Auto Generate Id
        private void AutoIdGenerate()
        {
            //var query = "select max(ProductId) from ProductList;";
            //var dt = this.Da.ExecuteQueryTable(query);
            //if (dt.Rows[0][0] == DBNull.Value)
            //{
            //    this.txtUserId.Text = "A-001";
            //    return;
            //}

            //var oldId = dt.Rows[0][0].ToString();
            //var s = oldId.Split('-');
            //var temp = Convert.ToInt32(s[1]);
            //var newId = "A-" + (++temp).ToString("d3");
            //this.txtUserId.Text = newId;
            // -x-x-x-x-xx--x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-
            //try
            //{
            //    var query = "select max(UserId) from SuperUser;";
            //    var dt = this.Da.ExecuteQueryTable(query);

            //    if (dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
            //    {
            //        this.txtUserId.Text = "S-001";
            //        return;
            //    }

            //    var oldId = dt.Rows[0][0].ToString(); // e.g. "S-005"
            //    var parts = oldId.Split('-');
            //    var num = Convert.ToInt32(parts[1]);
            //    var newId = "S-" + (++num).ToString("d3");
            //    this.txtUserId.Text = newId;
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("Error generating SellerId: " + exc.Message);
            //}

        }

        private void ClearAll()
        {
            // DML Text Box's
            this.txtUserName.Clear();
            this.txtUserPassword.Clear();
            this.dtpDOB.Text = "";
            this.txtUserPhone.Clear();
            this.txtUserNID.Clear();
            this.cmbUserRole.Text = "";          
                        
            this.dgvSellerList.ClearSelection();

            //this.AutoIdGenerate();
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
            catch (Exception exc)
            {
                MessageBox.Show("Eror: " + exc.Message);
            }
        }

        private void dgvSellerList_DoubleClick(object sender, EventArgs e)
        {
            //this.txtMemberName.Text = this.dgvMemberList.CurrentRow.Cells["colMemberName"].Value.ToString();
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

            catch (Exception exc)
            {
                MessageBox.Show("Eror:" + exc.Message);
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
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
                //MessageBox.Show(exc.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SellerList_Load(object sender, EventArgs e)
        {
            this.dgvSellerList.ClearSelection();
        }
    }
}
