using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SMS_2._0
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet3.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter1.Fill(this.smsDataSet3.stock);
            // TODO: This line of code loads data into the 'smsDataSet1.cashiers' table. You can move, or remove it, as needed.
            this.cashiersTableAdapter.Fill(this.smsDataSet1.cashiers);
            // TODO: This line of code loads data into the 'smsDataSet2.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.smsDataSet2.stock);

        }

        private void goBackBttn_Click(object sender, EventArgs e)
        {
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            AdminView childForm = new AdminView();
            childForm.Show();
            this.Close();
        }

        private void addStockBttn_Click(object sender, EventArgs e)
        {
            AddStock childForm = new AddStock();
            childForm.Show();
        }

        private void addCashierBttn_Click(object sender, EventArgs e)
        {
            AddCashier childForm = new AddCashier();
            childForm.Show();
        }

        private void removeCashierBttn_Click(object sender, EventArgs e)
        {
            RemoveCashier childForm = new RemoveCashier();
            childForm.Show();
        }

        private void removeStockBttn_Click(object sender, EventArgs e)
        {
            RemoveStock removeStock = new RemoveStock();
            removeStock.Show();
        }

        private void addMore_Click(object sender, EventArgs e)
        {
            AddMore childForm = new AddMore();
            childForm.Show();
        }

        private void moreBTTN_Click_1(object sender, EventArgs e)
        {
            MoreOfAdminView moreOfAdminView = new MoreOfAdminView();
            moreOfAdminView.Show();
        }

        private void AccountingBttn_Click(object sender, EventArgs e)
        {
            Accounting accounting = new Accounting();
            accounting.Show();
        }
    }
}
