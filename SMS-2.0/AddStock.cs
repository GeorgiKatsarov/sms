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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void addStockBttn_Click(object sender, EventArgs e)
        {
            if (priceTXTBOX.Text != "" && nameTXTBOX.Text != "" && quantityTXTBOX.Text != "" )
            { 
                string query = $"insert into sms.stock (name, quantity, price, deliveryPrice) values ('{nameTXTBOX.Text}', {decimal.Parse(quantityTXTBOX.Text)}, {decimal.Parse(priceTXTBOX.Text)}, {decimal.Parse(deliveryPriceTXTBOX.Text)} )";
                Database database = new Database();
                database.RunQuery(query);
                this.Close();
            }
            else
            {
                MessageBox.Show("No stock to be added", "Something went wrong");
            }
        }

        private void quantityTXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void priceTXTBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
