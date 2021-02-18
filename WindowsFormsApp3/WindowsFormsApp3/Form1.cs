using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            FillTextBox();


        }
        string t = null;
        idkModel context = new idkModel();


        private void customersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            t = "Customers";
            var c = context.Customers.ToList();
            dataGridView1.DataSource = c;
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = "Orders";
            var o = context.Orders.ToList();
            dataGridView1.DataSource = o;
        }

        private void orderItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //t = "Order Items";
            var oi = context.OrderItems.ToList();
            dataGridView1.DataSource = oi;
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = "Products";
            var p = context.Products.ToList();
            dataGridView1.DataSource = p;
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = "Suppliers";
            var s = context.Suppliers.ToList();
            dataGridView1.DataSource = s;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            choose frm = new choose();
            frm.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            int Id = (int)row.Cells["ID"].Value;
            switch (t)
            {

                case "Suppliers":
                    frmAddSupplier frm = new frmAddSupplier(Id);
                    frm.Show();
                    break;
                case "Customers":
                    frmAddCustomer frmc = new frmAddCustomer(Id);
                    frmc.Show();
                    break;
                case "Products":
                    frmAddProduct frmp = new frmAddProduct(Id);
                    frmp.Show();
                    break;
                case "Orders":
                    frmAddOrder frmo = new frmAddOrder(Id);
                    frmo.Show();
                    break;
                    //case "Order Items":
                    //    frmAddOrderItem frmoi = new frmAddOrderItem(Id);
                    //    frmoi.Show();
                    //    break;
            }
        }

        void FillTextBox()
        {
            //textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            var coll = new AutoCompleteStringCollection();
            using (idkModel idk = new idkModel())
            {
                var name = from a in idk.Products select a.ProductName;
                
                foreach(string i in name)
                {
                    coll.Add(i);
                }
                
            }
            var textBox = new TextBox
            {
                AutoCompleteCustomSource = coll,
                AutoCompleteMode =
                          AutoCompleteMode.SuggestAppend,
                AutoCompleteSource =
                          AutoCompleteSource.CustomSource,
                Location = new Point(370, 115),
                Width =  150,
                Visible = true,
                Name = "textbox1"
            };

            // Add the text box to the form.
            Controls.Add(textBox);
            
        }
        
        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void searchByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
