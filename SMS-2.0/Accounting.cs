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

        }
    }
}
