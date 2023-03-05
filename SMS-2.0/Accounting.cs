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
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private void Accounting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet6.profits' table. You can move, or remove it, as needed.
            this.profitsTableAdapter.Fill(this.smsDataSet6.profits);

        }

        private void calculateProfitsBttn_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Dictionary<int, Sale> salesDict = database.Sales();
            decimal sales = 0;
            decimal slimProfit = 0;
            decimal profit = 0;
            decimal profitPercentage = 0;
            foreach (var item in salesDict)
            {
                Database database2 = new Database();
                item.Value.Product = database2.Product(item.Value.IdOfProduct);
                sales += item.Value.Product.Price * item.Value.Quantity;
                slimProfit += item.Value.Product.DeliveryPrice * item.Value.Quantity;
            }
            profit = sales - slimProfit;
            profitPercentage = (profit / sales);
            Database database1 = new Database();
            database1.RunQuery($"INSERT INTO sms.profits (sales, netProfit, profitPercentage) VALUES('{sales}', '{profit}', '{profitPercentage}')");
            Accounting accounting = new Accounting();
            accounting.Show();
            this.Close();
        }
    }
}
