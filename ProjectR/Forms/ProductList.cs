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
    public partial class ProductList : UserControl
    {
        internal Form MainWindowF { get; set; }

        private static bool txtSearchProductsClick = true;

        private void DraggableWindows(Form a)
        {
            DragableWindow.MakeDraggable(a);
            DragableWindow.MakePanelDraggable(this, a);
        }

        public ProductList()
        {
            InitializeComponent();
        }
        public ProductList(Form a) : this()
        {
            DraggableWindows(a);
            this.MainWindowF = a;
        }

        private void txtSearchProducts_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchProducts.Text == "")
            {
                this.txtSearchProducts.Text = "Search product with name or id";
                txtSearchProductsClick = true;
            }
        }

        private void txtSearchProducts_Click(object sender, EventArgs e)
        {
            if (txtSearchProductsClick)
            {
                this.txtSearchProducts.Text = "";
                txtSearchProductsClick = false;
            }
        }
    }
}
