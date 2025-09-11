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

        internal Form MainWindowF { get; set; }

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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.pnlSideBarLeft.Visible = false;
            this.pnlForms.Controls.Clear();
            pnlForms.Controls.Add(LogINP);
        }
    }
}
