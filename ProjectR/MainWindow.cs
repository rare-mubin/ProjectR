using ProjectR.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectR
{
    public partial class MainWindow : Form
    {
        internal static Panel MainWindowPanel {  get; set; }
        internal static Panel SidePanel { get; set; }
        internal static DataAccess SqlDataAccess { get; set; }
        internal static DataTable LogInUser { get; set; }
        internal static Button MyProfile {  get; set; }

        internal static Panel AdminAccessOnlyBtn1;
        internal static Panel AdminAccessOnlyBtn2;
        internal static Panel AdminAccessOnlyBtn3;

        internal LogIn ucLogIn { get; set; }
        internal UserProfile ucUserProfile { get; set; }
        internal SellerList ucSellerList { get; set; }
        internal ReportsDashboard ucReportsDashboard { get; set; }
        internal ProductList ucProductList { get; set; }
        internal MemberList ucMemberList { get; set; }
        internal HomePage ucHomePage { get; set; }
        internal Sells ucSells { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DraggableWindows();
            MainWindowPanel = this.pnlForms;
            SidePanel = this.pnlSideBarLeft;
            MyProfile = this.btnMyProfile;
            AdminAccessOnlyBtn1 = this.pnlBtnAdminOnly1;
            AdminAccessOnlyBtn2 = this.pnlBtnAdminOnly2;
            AdminAccessOnlyBtn3 = this.pnlBtnAdminOnly3;
            this.ucLogIn = new LogIn(this);
        }

        private void DraggableWindows()
        {
            DragableWindow.MakeDraggable(this);
            DragableWindow.MakePanelDraggable(pnlTittlebar, this);
            SqlDataAccess = new DataAccess();
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAccess.ExecuteDMLQuery("Truncate TABLE TempCart");
            }
            catch { }
            
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.ucLogIn = new LogIn(this);
            this.ChangeWindow(this.ucLogIn);
        }
        
        private void ChangeWindow(UserControl NextPage)
        {
            NextPage.Dock = DockStyle.Fill;
            this.pnlForms.Controls.Clear();
            this.pnlForms.Controls.Add(NextPage);
            NextPage.Show();
        }

        private void VisibleIndiactor()
        {
            this.pnlIndicator1.Visible = false;
            this.pnlIndicator2.Visible = false;
            this.pnlIndicator3.Visible = false;
            this.pnlIndicator4.Visible = false;
            this.pnlIndicator5.Visible = false;
            this.pnlIndicator6.Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.pnlSideBarLeft.Visible = false;
            this.ChangeWindow(this.ucLogIn);
            AdminAccessOnlyBtn(false);
        }

        private void btnProductBrowser_Click(object sender, EventArgs e)
        {
            this.ucHomePage = new HomePage();
            this.ChangeWindow(this.ucHomePage);
            this.VisibleIndiactor();
            this.pnlIndicator1.Visible = true;
        }

        private void btnAllProductList_Click(object sender, EventArgs e)
        {
            this.ucProductList = new ProductList();
            this.ChangeWindow(this.ucProductList);
            this.VisibleIndiactor();
            this.pnlIndicator4.Visible = true;
        }

        private void btnSellersList_Click(object sender, EventArgs e)
        {
            this.ucSellerList = new SellerList();
            this.ChangeWindow(this.ucSellerList);
            this.VisibleIndiactor();
            this.pnlIndicator6.Visible = true;
        }

        private void btnSells_Click(object sender, EventArgs e)
        {
            this.ucSells = new Sells();
            this.ChangeWindow(this.ucSells);
            this.VisibleIndiactor();
            this.pnlIndicator2.Visible = true;
        }

        private void btnReportsDashboard_Click(object sender, EventArgs e)
        {
            this.ucReportsDashboard = new ReportsDashboard();
            this.ChangeWindow(this.ucReportsDashboard);
            this.VisibleIndiactor();
            this.pnlIndicator3.Visible = true;
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            this.ucUserProfile = new UserProfile();
            this.ChangeWindow(this.ucUserProfile);
        }

        private void btnMembersList_Click(object sender, EventArgs e)
        {
            this.ucMemberList = new MemberList();
            this.ChangeWindow(this.ucMemberList);
            this.VisibleIndiactor();
            this.pnlIndicator5.Visible = true;
        }

        internal static void AdminAccessOnlyBtn(bool a)
        {
            AdminAccessOnlyBtn1.Visible = a;
            AdminAccessOnlyBtn2.Visible = a;
            AdminAccessOnlyBtn3.Visible = a;
        }
    }
}
