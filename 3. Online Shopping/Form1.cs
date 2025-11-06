using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Online_Shopping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDisplayDetails_Click(object sender, EventArgs e)
        {
            try
            {
                ElectronicProduct product = new ElectronicProduct(textBoxName.Text, numericUpDownPrice.Value, Convert.ToInt32(numericUpDownWarranty.Value));
                MessageBox.Show(product.GetDetails(), "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
