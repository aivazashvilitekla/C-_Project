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
    public partial class frmAddCustomer : Form
    {
        public int? Id;
        public frmAddCustomer()
        {
            InitializeComponent();
            Id = null;
            
        }
        public frmAddCustomer(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            fillInfo(Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (idkModel idk = new idkModel())
                {
                    Customer c;
                    if (Id.HasValue)
                    {
                        c = (from cc in idk.Customers
                             where cc.Id == Id
                             select cc).FirstOrDefault();
                        
                    }
                    else
                    {
                        c = new Customer();
                    }
                    c.FirstName = txtBox_fn.Text;
                    c.LastName = txtBox_ln.Text;
                    c.City = txtBox_ct.Text;
                    c.Country = txtBox_cntry.Text;
                    c.Phone = txtBox_ph.Text;
                    if (!Id.HasValue)
                        idk.Customers.Add(c);
                    idk.Customers.Add(c);
                    idk.SaveChanges();
                }
                MessageBox.Show("ოპერაცია წარმატებით დასრულდა", "წარმატება", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
        public void fillInfo(int id)
        {
            using (idkModel idk = new idkModel())
            {
                try
                {
                    var customers = (from ep in idk.Customers
                                     where ep.Id == id
                                     select ep).ToList();
                    foreach (Customer i in customers)
                    {
                        txtBox_fn.Text = i.FirstName;
                        txtBox_ln.Text = i.LastName;
                        txtBox_cntry.Text = i.Country;
                        txtBox_ct.Text = i.City;
                        txtBox_ph.Text = i.Phone;
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
