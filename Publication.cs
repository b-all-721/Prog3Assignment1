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
    public partial class Publication : Form
    {
        public Publication()
        {
            InitializeComponent();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            Delegate del = new Delegate();
            
            string pubContent = txtPubContent.Text;
            PublicationClass newPublication = new PublicationClass(pubContent);
            MessageBox.Show(newPublication.sendPublication("Your publication: "));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
