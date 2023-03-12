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
    public partial class MoreOfAdminView : Form
    {
        public MoreOfAdminView()
        {
            InitializeComponent();
        }

        private void MoreOfAdminView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet5.newdelivery' table. You can move, or remove it, as needed.
            this.newdeliveryTableAdapter.Fill(this.smsDataSet5.newdelivery);
            // TODO: This line of code loads data into the 'smsDataSet5.addedstock' table. You can move, or remove it, as needed.
            this.addedstockTableAdapter.Fill(this.smsDataSet5.addedstock);
            // TODO: This line of code loads data into the 'smsDataSet4.soldstock' table. You can move, or remove it, as needed.
            this.soldstockTableAdapter.Fill(this.smsDataSet4.soldstock);
            // TODO: This line of code loads data into the 'smsDataSet4.removedstock' table. You can move, or remove it, as needed.
            this.removedstockTableAdapter.Fill(this.smsDataSet4.removedstock);

        }
    }
}
