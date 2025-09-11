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
    public partial class HomePage : UserControl
    {
        internal Form MainWindowF { get; set; }
        internal Form Previous { get; set; }

        public HomePage()
        {
            InitializeComponent();
        }
        public HomePage(Form MainWindow, Form previous) : this()
        {
            DraggableWindows(MainWindow);
            MainWindowF = MainWindow;
            this.Previous = previous;
        }
        private void DraggableWindows(Form a)
        {
            DragableWindow.MakeDraggable(a);
            DragableWindow.MakePanelDraggable(pnlMain, a);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MainWindow.MainWindowPanel.Controls.Clear();
            MainWindow.MainWindowPanel.Controls.Add(Previous);
            Previous.Show();
        }
    }
}
