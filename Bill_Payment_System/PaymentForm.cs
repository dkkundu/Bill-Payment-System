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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            retailerForm payment = new retailerForm();
            payment.Show();
        }

        private void bill_no(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter your bill no")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void bill_no_leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter your bill no";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void contact_no(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter a contact no")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void contact_no_leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter a contact no";
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
            confirmForm confirm_form = new confirmForm();
            confirm_form.Show();
        }
    }
}
