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
    public partial class SellerList : UserControl
    {
        internal Form MainWindowF { get; set; }

        public SellerList()
        {
            InitializeComponent();
        }

        public SellerList(Form a) : this()
        {
            this.MainWindowF = a;
        }
    }
}
