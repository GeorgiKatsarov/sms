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
    public partial class RemoveCashier : Form
    {
        public RemoveCashier()
        {
            InitializeComponent();
        }

        private void RemoveCashierBttn_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.RunQuery($"DELETE FROM `cashiers` WHERE `cashiers`.`id` = {int.Parse(idTXTBOX.Text)}");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idTXTBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
