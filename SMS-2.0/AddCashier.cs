﻿using System;
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
    public partial class AddCashier : Form
    {
        public AddCashier()
        {
            InitializeComponent();
        }

        private void addCashierBttn_Click(object sender, EventArgs e)
        {
            if (firstNameTXTBOX.Text != "" && lastNameTXTBOX.Text != "" )
            {
                string query = $"insert into sms.cashiers (firstName, lastName) values ('{firstNameTXTBOX.Text}', '{lastNameTXTBOX.Text}' )";
                Database database = new Database();
                database.RunQuery(query);
                this.Close();
            }
            else
            {
                MessageBox.Show("No cashier to be added", "Something went wrong");
            }
        }
    }
}
