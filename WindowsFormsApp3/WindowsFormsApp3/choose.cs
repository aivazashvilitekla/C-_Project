using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class choose : Form
    {
        int i;
        public choose()
        {
            InitializeComponent();
        }
        public choose(int i)
        {
            InitializeComponent();
            int yn = i;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (comboBox2.SelectedItem)
            {

                case "Suppliers":
                    frmAddSupplier frm = new frmAddSupplier();
                    frm.Show();
                    break;
                case "Customers":
                    frmAddCustomer frmc = new frmAddCustomer();
                    frmc.Show();
                    break;
                case "Products":
                    frmAddProduct frmp = new frmAddProduct();
                    frmp.Show();
                    break;
                case "Orders":
                    frmAddOrder frmo = new frmAddOrder();
                    frmo.Show();
                    break;
                //case "Order Items":
                //    frmAddOrderItem frmoi = new frmAddOrderItem();
                //    frmoi.Show();
                //    break;
            }
        }
    }
}
