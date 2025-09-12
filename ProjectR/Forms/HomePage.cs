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

        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(Form a) : this()
        {
            this.MainWindowF = a;
        }

        private void btnGames_MouseHover(object sender, EventArgs e)
        {
            this.btnGames.FlatAppearance.BorderSize = 1;
        }

        private void btnGames_MouseLeave(object sender, EventArgs e)
        {
            this.btnGames.FlatAppearance.BorderSize = 0;
        }

        private void btnLaptops_MouseHover(object sender, EventArgs e)
        {
            this.btnLaptops.FlatAppearance.BorderSize = 1;
        }

        private void btnLaptops_MouseLeave(object sender, EventArgs e)
        {
            this.btnLaptops.FlatAppearance.BorderSize = 0;
        }

        private void btnPcParts_MouseHover(object sender, EventArgs e)
        {
            this.btnPcParts.FlatAppearance.BorderSize = 1;
        }

        private void btnPcParts_MouseLeave(object sender, EventArgs e)
        {
            this.btnPcParts.FlatAppearance.BorderSize = 0;
        }
    }
}
