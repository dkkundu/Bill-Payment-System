using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_Payment_System
{
    public partial class dealerForm : Form
    {
        public dealerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BalanceTransferForm balance_transfer_form = new BalanceTransferForm();
            balance_transfer_form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage mainpage_form = new mainpage();
            mainpage_form.Show();
        }
    }
}
