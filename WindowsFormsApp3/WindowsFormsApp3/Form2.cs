using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        string conn_string = ConfigurationManager.ConnectionStrings["myconn"].ToString();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(conn_string))
                {
                    string query = @"SELECT Customer.FirstName AS 'FirstName', Customer.LastName AS 'LastName', [Order].OrderNumber AS 'OrderNumber', [Order].TotalAmount AS 'TotalAmount', [Order].OrderDate AS 'OrderDate', OrderItem.Quantity AS 'Quantity', Product.ProductName AS 'ProductName', Product.UnitPrice AS 'UnitPrice' FROM Customer INNER JOIN[Order] ON Customer.Id = [Order].CustomerId INNER JOIN OrderItem ON [Order].Id = OrderItem.OrderId INNER JOIN Product ON OrderItem.ProductId = Product.Id INNER JOIN Supplier ON Product.SupplierId = Supplier.Id";
                    SqlCommand comm = new SqlCommand(query, conn);
                    SqlDataAdapter ad = new SqlDataAdapter(comm);
                    DTProduct ds = new DTProduct();
                    ad.Fill(ds);
                    DataTable dt = ds.Tables["DT"];
                    ReportDataSource repds1 = new ReportDataSource("DataSet3", dt);
                    string rPath = @"C:\Users\tekla aivazashvili\source\repos\WindowsFormsApp3\WindowsFormsApp3\Report1.rdlc";
                    reportViewer1.ProcessingMode = ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportPath = rPath;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(repds1);
                    reportViewer1.Visible = true;
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
