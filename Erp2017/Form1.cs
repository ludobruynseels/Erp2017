using System;
using System.Windows.Forms;
using Erp2017.Data.InvoicesDataSetTableAdapters;

namespace Erp2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ds = new Data.InvoicesDataSet();
            var ta = new CustomersTableAdapter();

            ta.Fill(ds.Customers);

            dgCustomers.DataSource = ds.Customers;
        }
    }
}
