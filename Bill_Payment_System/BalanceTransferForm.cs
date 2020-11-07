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
    public partial class BalanceTransferForm : Form
    {
        public BalanceTransferForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dealerForm balance_transfer = new dealerForm();
            balance_transfer.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void recipient_no(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter recipient number")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void recipient_no_leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter recipient number";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void amount(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter transfer amount")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void amount_leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter transfer amount";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void pin_no(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter your pin no")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void pin_no_leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Enter your pin no";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferBalanceConfirmForm balance_transfer_confirm_form = new TransferBalanceConfirmForm();
            balance_transfer_confirm_form.Show();
        }
    }
}
