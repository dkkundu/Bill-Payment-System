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
    public partial class TransferBalanceConfirmForm : Form
    {
        public TransferBalanceConfirmForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BalanceTransferForm balance_transfer_form = new BalanceTransferForm();
            balance_transfer_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BlTransactionForm transaction_form = new BlTransactionForm();
            transaction_form.Show();
        }
    }
}
