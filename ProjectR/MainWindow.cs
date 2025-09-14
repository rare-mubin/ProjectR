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

        internal LogIn LogINP { get; set; }

        private void DraggableWindows()
        {
            DragableWindow.MakeDraggable(this);
            DragableWindow.MakePanelDraggable(pnlTittlebar, this);
        }
        public MainWindow()
        {
            InitializeComponent();
            DraggableWindows();
            MainWindowPanel = this.pnlForms;
            SidePanel = this.pnlSideBarLeft;
            this.LogINP = new LogIn(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.LogINP.Dock = DockStyle.Fill;
            //NextPage.TopLevel = false;
            pnlForms.Controls.Clear();
            pnlForms.Controls.Add(this.LogINP);
            this.LogINP.Show();
        }
        
        private void ChangeWindow(UserControl NextPage)
        {
            MainWindow.MainWindowPanel.Controls.Clear();
            MainWindow.SidePanel.Visible = true;
            MainWindow.MainWindowPanel.Controls.Add(NextPage);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn a = new LogIn();
            this.pnlSideBarLeft.Visible = false;
            this.pnlForms.Controls.Clear();
            pnlForms.Controls.Add(a);
        }

        private void btnProductBrowser_Click(object sender, EventArgs e)
        {
            HomePage NextPage = new HomePage(this);
            NextPage.Dock = DockStyle.Fill;
            ChangeWindow(NextPage);
            NextPage.Show();
        }

        private void btnAllProductList_Click(object sender, EventArgs e)
        {
            ProductList NextPage = new ProductList(this);
            NextPage.Dock = DockStyle.Fill;
            ChangeWindow(NextPage);
            NextPage.Show();
        }

        private void btnSellersList_Click(object sender, EventArgs e)
        {
            SellerList NextPage = new SellerList(this);
            NextPage.Dock = DockStyle.Fill;
            ChangeWindow(NextPage);
            NextPage.Show();
        }

        private void btnSells_Click(object sender, EventArgs e)
        {
            Sells NextPage = new Sells(this);
            NextPage.Dock = DockStyle.Fill;
            ChangeWindow(NextPage);
            NextPage.Show();
        }

        private void btnReportsDashboard_Click(object sender, EventArgs e)
        {
            ReportsDashboard NextPage = new ReportsDashboard(this);
            NextPage.Dock = DockStyle.Fill;
            ChangeWindow(NextPage);
            NextPage.Show();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            UserProfile NextPage = new UserProfile(this);
            NextPage.Dock = DockStyle.Fill;
            ChangeWindow(NextPage);
            NextPage.Show();
        }

        private void btnMembersList_Click(object sender, EventArgs e)
        {
            MemberList NextPage = new MemberList(this);
            NextPage.Dock = DockStyle.Fill;
            ChangeWindow(NextPage);
            NextPage.Show();
        }
    }
}
