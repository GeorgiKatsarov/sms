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
            database.RunQuery($"DELETE FROM `stock` WHERE `stock`.`id` = {int.Parse(idTXTBOX.Text)}");
            this.Close();
        }
    }
}
