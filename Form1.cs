using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnManageSubs_Click(object sender, EventArgs e)
        {
            subscriptionForm subscriptionForm = new subscriptionForm();
            this.Hide();
            subscriptionForm.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPublishNot_Click(object sender, EventArgs e)
        {
            PublishNotification pubNotification = new PublishNotification();
            this.Hide();
            pubNotification.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
