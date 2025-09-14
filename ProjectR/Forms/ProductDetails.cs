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
    public partial class ProductDetails : UserControl
    {
        private static string ProductId {  get; set; }

        public ProductDetails()
        {
            InitializeComponent();
        }
        public ProductDetails(string b) : this()
        {
            ProductId = b;
        }
    }
}
