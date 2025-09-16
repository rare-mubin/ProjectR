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
    public partial class Checkout : UserControl
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Dock = DockStyle.Fill;
            MainWindow.MainWindowPanel.Controls.Clear();
            MainWindow.MainWindowPanel.Controls.Add(homePage);
            homePage.Show();
        }
    }
}
