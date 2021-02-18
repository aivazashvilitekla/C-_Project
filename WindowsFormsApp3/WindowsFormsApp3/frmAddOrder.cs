using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmAddOrder : Form
    {
        public int? Id;
        public frmAddOrder()
        {
            InitializeComponent();
            ordR();
            cust();
            Id = null;
        }
        public frmAddOrder(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            //fillInfo(Id);
        }
        public void ordR()
        {
            try
            {
                Random rand = new Random();
                int orderNumber = rand.Next(1, 10000);
                using (idkModel idk = new idkModel())
                {
                    var orderNumMatch = idk.Orders.ToList().FirstOrDefault(i => i.OrderNumber.Equals(orderNumber));

                    while (orderNumMatch != null)
                    {
                        orderNumber = rand.Next(1, 10000);
                        orderNumMatch = idk.Orders.ToList().FirstOrDefault(i => i.OrderNumber.Equals(orderNumber));
                    }
                }
                numericUpDown2.Text = orderNumber.ToString();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void cust()
        {
            using (idkModel idk = new idkModel())
            {
                try
                {
                    
                    comboBox1_customer.DataSource = idk.Customers.Select(i => i.FirstName).ToList();
                    comboBox1_customer.Text = comboBox1_customer.SelectedItem.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!");
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (idkModel idk = new idkModel())
            {
                using (DbContextTransaction transaction = idk.Database.BeginTransaction())
                {
                    try
                    {
                        Order o;

                        if (Id.HasValue)
                        {
                            o = (from odi in idk.Orders
                                   join pd in idk.OrderItems on odi.Id equals pd.OrderId
                                   where pd.Id == Id
                                   select odi).FirstOrDefault();
                        }
                        else
                        {
                            o = new Order();

                            o.OrderDate = DateTime.Now;
                            o.OrderNumber = numericUpDown2.Text;
                        }
                        o.CustomerId = (from ct in idk.Customers
                                         where ct.FirstName == comboBox1_customer.Text
                                         select ct.Id).FirstOrDefault();
                        o.OrderDate = dateTimePicker1.Value;
                        o.OrderNumber = numericUpDown2.Text;
                        
                        o.TotalAmount = numericUpDown1.Value;
                        if (!Id.HasValue)
                        
                            idk.Orders.Add(o);
                        
                        idk.Orders.Add(o);
                        idk.SaveChanges();
                        transaction.Commit();
                        MessageBox.Show("ოპერაცია წარმატებით დასრულდა", "წარმატება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ee)
                    {
                        //transaction.Rollback();
                        MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Close();
                    }
                }
            }
        }
        
    }
}
