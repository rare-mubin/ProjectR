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
        public static Panel MainWindowPanel {  get; set; }
        internal Form MainWindowF { get; set; }

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
            LogIn NextPage = new LogIn(this);
            NextPage.Dock = DockStyle.Fill;
            NextPage.TopLevel = false;
            pnlForms.Controls.Clear();
            pnlForms.Controls.Add(NextPage);
            NextPage.Show();
        }
    }
}
