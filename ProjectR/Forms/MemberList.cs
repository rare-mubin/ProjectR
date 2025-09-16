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
    public partial class MemberList : UserControl
    {
        internal DataAccess Da { get; set; }
        private static bool txtSearchMembersClick = true;


        public MemberList()
        {
            InitializeComponent();
            this.Da = MainWindow.SqlDataAccess;
            this.PopulateGridView();
        }

        // Populate Grid view
        private void PopulateGridView(string sql = "select * from MemberList;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvMemberList.AutoGenerateColumns = false;
                this.dgvMemberList.DataSource = ds.Tables[0];
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }
        // clear all
        private void ClearAll()
        {
            this.txtMemberName.Clear();
            this.txtMemberPhone.Clear();
            this.txtMemberPoints.Clear();
            this.dgvMemberList.ClearSelection();
        }

        // [Fill All the Forms]
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtMemberName.Text) || string.IsNullOrEmpty(this.txtMemberPhone.Text) ||
                string.IsNullOrEmpty(this.txtMemberPoints.Text))
                return false;
            else
                return true;
        }

        // Search Box
        private void txtSearchMembers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = this.txtSearchMembers.Text.Trim();

                string sql = $"select * from MemberList where MemberName LIKE '%{searchText}%';";
                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        // Save Member Information
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("PLEASE FILL ALL INFORMATION");
                    return;
                }

                string phone = this.txtMemberPhone.Text.Trim();

                // check if member exists
                string checkSql = $"select * from MemberList where MemberPhone = '{phone}';";
                var ds = this.Da.ExecuteQuery(checkSql);

                string sql;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Member exists → Update
                    sql = $"update MemberList set MemberName = '{this.txtMemberName.Text}', MemberPoints = {this.txtMemberPoints.Text} where MemberPhone = '{phone}';";
                }
                else
                {
                    // Member does not exist → Insert
                    sql = $"insert into MemberList (MemberName, MemberPhone, MemberPoints) values ('{this.txtMemberName.Text}', '{phone}', {this.txtMemberPoints.Text});";
                }

                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Member Information Saved Successfully");
                else
                    MessageBox.Show("Member Information could not be saved");

                this.ClearAll();
                this.PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void dgvMemberList_DoubleClick(object sender, EventArgs e)
        {
            this.txtMemberName.Text = this.dgvMemberList.CurrentRow.Cells["colMemberName"].Value.ToString();
            this.txtMemberPoints.Text = this.dgvMemberList.CurrentRow.Cells["colMemberPoints"].Value.ToString();
            this.txtMemberPhone.Text = this.dgvMemberList.CurrentRow.Cells["colMemberPhone"].Value.ToString();
        }

        // Clear All 
        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClearAll();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        // Remove Member
        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvMemberList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvMemberList.CurrentRow.Cells["colMemberPhone"].Value.ToString();
                var title = this.dgvMemberList.CurrentRow.Cells["colMemberName"].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + title + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from MemberList where MemberPhone = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(title.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Member Has not been Removed");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
            this.dgvMemberList.ClearSelection();
        }

        private void txtSearchMembers_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchMembers.Text == "")
            {
                this.txtSearchMembers.Text = "Search Users...";
                txtSearchMembersClick = true;
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

        private void txtSearchMembers_Click(object sender, EventArgs e)
        {
            if (txtSearchMembersClick)
            {
                this.txtSearchMembers.Text = "";
                txtSearchMembersClick = false;
            }
        }
    }
}
