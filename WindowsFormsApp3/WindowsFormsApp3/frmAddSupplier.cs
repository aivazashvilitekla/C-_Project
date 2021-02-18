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
    public partial class frmAddSupplier : Form
    {
        public int? yn;
        public frmAddSupplier()
        {
            InitializeComponent();
            yn = null;
        }
        public frmAddSupplier(int yn)
        {
            InitializeComponent();
            this.yn = yn;
            fillInfo(yn);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (idkModel idk = new idkModel())
            {
                try
                {
                    Supplier sp;
                    if (yn.HasValue)
                    {
                        sp = (from ep in idk.Suppliers
                              where ep.Id == yn
                              select ep).FirstOrDefault();
                    }
                    else
                    {
                        sp = new Supplier();
                    }
                    sp.CompanyName = textBox_name.Text;
                    sp.ContactName = textBox_contName.Text;
                    sp.ContactTitle = textBox_title.Text;
                    sp.Country = textBox1_country.Text;
                    sp.City = textBox2_city.Text;
                    sp.Phone = textBox_phone.Text;
                    sp.Fax = textBox_fax.Text;
                    if (!yn.HasValue)
                        idk.Suppliers.Add(sp);

                    idk.Suppliers.Add(sp);
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
                    var suppliers = (from ep in idk.Suppliers
                                     where ep.Id == id
                                     select ep).ToList();
                    foreach (Supplier i in suppliers)
                    {
                        textBox_name.Text = i.CompanyName;
                        textBox_contName.Text = i.ContactName;
                        textBox_title.Text = i.ContactTitle;
                        textBox1_country.Text = i.Country;
                        textBox2_city.Text = i.City;
                        textBox_phone.Text = i.Phone;
                        textBox_fax.Text = i.Fax;
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
