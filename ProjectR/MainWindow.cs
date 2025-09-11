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
        public static Panel MainWindowPanel {  get; set; }
        private void DraggableWindows()
        {
            DragableWindow.MakeDraggable(this);
            DragableWindow.MakePanelDraggable(pnlMain, this);
            DragableWindow.MakePanelDraggable(pnlTittlebar, this);
        }
        public MainWindow()
        {
            InitializeComponent();
            DraggableWindows();
            MainWindowPanel = this.pnlMain;
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
            LogIn homePage = new LogIn(this);
            homePage.Dock = DockStyle.Fill;
            homePage.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(homePage);
            homePage.Show();
        }
    }
}
