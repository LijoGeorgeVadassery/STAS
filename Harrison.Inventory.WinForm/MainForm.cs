using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harrison.Inventory.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void districtsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taxDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tax_Details taxform=new Tax_Details();
            taxform.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendors vendorForm = new Vendors();
            vendorForm.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void financialYearsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialYear FinacialForm = new FinancialYear();
            FinacialForm.Show();
        }
    }
}
