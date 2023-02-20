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
            if (int.Parse(quantityTXTBOX.Text) > 0 )
            {
                Database database = new Database();
                int newQuantity = database.GetQuantity(int.Parse(idTXTBOX.Text)) - int.Parse(quantityTXTBOX.Text);
                database.RunQuery($"UPDATE stock SET quantity = {newQuantity} WHERE stock.id = {idTXTBOX.Text}");
                if (database.GetQuantity(int.Parse(idTXTBOX.Text)) == 0)
                {
                    database.RunQuery($"DELETE FROM `stock` WHERE `stock`.`id` = {int.Parse(idTXTBOX.Text)}");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Quantity must be positive");
                quantityTXTBOX.Text = "";
                idTXTBOX.Text = "";
            }
          
        }

        private void RemoveStock_Load(object sender, EventArgs e)
        {

        }
    }
}
