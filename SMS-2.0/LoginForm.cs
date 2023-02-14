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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void adminLoginBttn_Click(object sender, EventArgs e)
        {
            if (usernameTXTBX.Text != "" && passwordTXTBX.Text != "")
            {
                Database database = new Database();
                if (database.AdminCheckIn(usernameTXTBX.Text, passwordTXTBX.Text) == true)
                {
                    AdminView childForm = new AdminView();
                    childForm.Show();
                }
                else
                {
                    MessageBox.Show("Try again!");
                }
            }
            else
            {
                MessageBox.Show("Fill the information! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
