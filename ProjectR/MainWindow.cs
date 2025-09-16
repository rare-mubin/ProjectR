using ProjectR.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.ucLogIn = new LogIn(this);
            this.ucUserProfile = new UserProfile();
            this.ucSellerList = new SellerList();
            this.ucProductList = new ProductList();
            this.ucMemberList = new MemberList();
            this.ucReportsDashboard = new ReportsDashboard();
            this.ucSells = new Sells();
            this.ucHomePage = new HomePage();
        }

        private void DraggableWindows()
        {
            DragableWindow.MakeDraggable(this);
            DragableWindow.MakePanelDraggable(pnlTittlebar, this);
            SqlDataAccess = new DataAccess();
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            SqlDataAccess.ExecuteDMLQuery("Truncate TABLE TempCart");
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.ChangeWindow(this.ucLogIn);
        }
        
        private void ChangeWindow(UserControl NextPage)
        {
            NextPage.Dock = DockStyle.Fill;
            this.pnlForms.Controls.Clear();
            this.pnlForms.Controls.Add(NextPage);
            NextPage.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.pnlSideBarLeft.Visible = false;
            this.ChangeWindow(this.ucLogIn);
        }

        private void btnProductBrowser_Click(object sender, EventArgs e)
        {
            this.ChangeWindow(this.ucHomePage);
        }

        private void btnAllProductList_Click(object sender, EventArgs e)
        {
            this.ChangeWindow(this.ucProductList);
        }

        private void btnSellersList_Click(object sender, EventArgs e)
        {
            this.ChangeWindow(this.ucSellerList);
        }

        private void btnSells_Click(object sender, EventArgs e)
        {
            this.ChangeWindow(this.ucSells);
        }

        private void btnReportsDashboard_Click(object sender, EventArgs e)
        {
            this.ChangeWindow(this.ucReportsDashboard);
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            this.ChangeWindow(this.ucUserProfile);
        }

        private void btnMembersList_Click(object sender, EventArgs e)
        {
            this.ChangeWindow(this.ucMemberList);
        }
    }
}
