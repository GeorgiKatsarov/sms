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
    public partial class RemoveStock : Form
    {
        public RemoveStock()
        {
            InitializeComponent();
        }

        private void RemoveStockBttn_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            int newQuantity = database.GetQuantity(int.Parse(idTXTBOX.Text)) - int.Parse(quantityTXTBOX.Text);
            database.RunQuery($"UPDATE stock SET quantity = {newQuantity} WHERE stock.id = {idTXTBOX.Text}");
            Database database1 = new Database();
            database1.RunQuery($"INSERT INTO sms.removedstock (removedProductID, quantityOfProduct) VALUES ('{int.Parse(idTXTBOX.Text)}','{decimal.Parse(quantityTXTBOX.Text)}')");
            this.Close();


        }

        private void RemoveStock_Load(object sender, EventArgs e)
        {

        }
    }
}
