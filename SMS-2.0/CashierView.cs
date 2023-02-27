using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace SMS_2._0
{
    public partial class CashierView : Form
    {
        List<Product> products;
        public CashierView()
        {
            products = new List<Product>();
            InitializeComponent();
        }

        private void CashierView_Load(object sender, EventArgs e)
        {
            this.stockTableAdapter.Fill(this.smsDataSet.stock);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (idTXTBOX.Text != "" && quantityTXTBOX.Text != "")
            {
                Database database = new Database();
                Product product = database.Product(int.Parse(idTXTBOX.Text), int.Parse(quantityTXTBOX.Text));
                products.Add(product);


                idTXTBOX.Text = "";
                quantityTXTBOX.Text = "";
            }
            else
            {
                MessageBox.Show("You have to fill both text boxes");
                idTXTBOX.Text = "";
                quantityTXTBOX.Text = "";
            }

        }

        private void finaliseButton_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Database database1 = new Database();
            decimal total = new decimal();
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("Thank you for shoping with us");
            receipt.AppendLine("------------------------------");
            foreach (var item in products)
            {
                total += item.Price * item.Quantity;
                receipt.AppendLine($"{item.Id} -- {item.Name} -- {item.Quantity} -- {item.Price}");
                int newQuantity = database.GetQuantity(item.Id);
                newQuantity -= item.Quantity;
                database.RunQuery($"UPDATE stock SET quantity = {newQuantity} WHERE stock.id = {item.Id}");
                database.RunQuery($"INSERT INTO sms.soldstock (soldProductID, quantity) VALUES( '{item.Id}', '{item.Quantity}')");
            }

            receipt.AppendLine($"Your total is {total:f2}BGN");
            MessageBox.Show(receipt.ToString());

            products.Clear();
            CashierView cashierView = new CashierView();
            cashierView.Show();
            this.Close();
        }
    }
}
