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

        internal Form MainWindowF { get; set; }
        public MemberList()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();

        }

        public MemberList(Form a) : this()
        {
            this.MainWindowF = a;
        }






        // Populate Grid view
        private void PopulateGridView(string sql = "select * from MemberList;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvMemberList.AutoGenerateColumns = false;
            this.dgvMemberList.DataSource = ds.Tables[0];
            this.ClearAll();
        }
        // clear all
        private void ClearAll()
        {
            this.txtMemberName.Clear();
            this.txtMemberPhone.Clear();
            this.txtMemberPoints.Clear();
            //this.cmbProductCategory.SelectedIndex = -1;       
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
            var sql = $"select * from MemberList where MemberName LIKE '%{this.txtSearchMembers.Text}%';";
            this.PopulateGridView(sql);
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("PLEASE FILL ALL THE INFORMATIONS");
                    return;
                }
                var sql = $"insert into MemberList (MemberName,MemberPhone,MemberPoints) values ('{this.txtMemberName.Text}','{this.txtMemberPhone.Text}',{this.txtMemberPoints.Text});";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
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

        private void dgvMemberList_DoubleClick(object sender, EventArgs e)
        {
            this.txtMemberName.Text = this.dgvMemberList.CurrentRow.Cells["colMemberName"].Value.ToString();
            this.txtMemberPoints.Text = this.dgvMemberList.CurrentRow.Cells["colMemberPoints"].Value.ToString();
            this.txtMemberPhone.Text = this.dgvMemberList.CurrentRow.Cells["colMemberPhone"].Value.ToString();
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("PLEASE FILL ALL INFORMATION");
                    return;
                }
                var sql = $"update MemberList set MemberName = '{this.txtMemberName.Text}' , MemberPoints = {this.txtMemberPoints.Text} where MemberPhone = '{this.txtMemberPhone.Text}';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
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
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
    }
}
