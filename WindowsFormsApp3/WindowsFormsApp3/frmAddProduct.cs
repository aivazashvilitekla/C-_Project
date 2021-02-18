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
    public partial class frmAddProduct : Form
    {
        public int? Id;
        public frmAddProduct()
        {
            InitializeComponent();
            sup();
            Id = null;
        }
        public frmAddProduct(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            fillInfo(Id);
        }
        public void sup()
        {
            using (idkModel idk = new idkModel())
            {
                try
                {
                    comboBox_supplier.DataSource = idk.Suppliers.Select(i => i.CompanyName).ToList();
                    comboBox_supplier.Text = comboBox_supplier.SelectedItem.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!");
                }
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            using (idkModel idk = new idkModel())
            {
                try
                {
                    Product pd;
                    if (Id.HasValue)
                    {
                        pd = (from p in idk.Products
                              join s in idk.Suppliers on p.SupplierId equals s.Id
                              where p.Id == Id
                              select p).FirstOrDefault();
                    }
                    else
                    {
                        pd = new Product();
                    }
                    pd.ProductName = textBox_name.Text;
                    pd.SupplierId = (from ct in idk.Suppliers
                                     where ct.CompanyName == comboBox_supplier.Text
                                     select ct.Id).FirstOrDefault();
                    pd.UnitPrice = numericUpDown_price.Value;
                    pd.Package = textBox_package.Text;
                    pd.IsDiscontinued = checkBox_discontinued.Checked;
                    if (!Id.HasValue)
                        idk.Products.Add(pd);
                    idk.Products.Add(pd);
                    idk.SaveChanges();
                    MessageBox.Show("ოპერაცია წარმატებით დასრულდა", "წარმატება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Close();
                }
            }
        }
        public void fillInfo(int id)
        {
            using (idkModel idk = new idkModel())
            {
                try
                {
                    var pd = (from p in idk.Products
                              join s in idk.Suppliers on p.SupplierId equals s.Id
                              where p.Id == Id
                              select p).ToList();
                    foreach (Product i in pd)
                    {
                        textBox_name.Text = i.ProductName;
                        comboBox_supplier.SelectedIndex = comboBox_supplier.FindString(i.Supplier.CompanyName);
                        numericUpDown_price.Value = Convert.ToDecimal(i.UnitPrice);
                        textBox_package.Text = i.Package;
                        checkBox_discontinued.Checked = i.IsDiscontinued;
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
