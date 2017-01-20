using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class subscriptionForm : Form 
    {
        public subscriptionForm()
        {
            InitializeComponent();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {

            string inputPhone = txtPhoneNum.Text;
            Delegate del1 = new Delegate();
            
            //validation for email
            string inputEmail = txtEmail.Text;

            if (checkBoxEmail.Checked)
            {
                string expresion;
                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                // If valid...
                if (Regex.IsMatch(inputEmail, expresion))
                {
                    if (Regex.Replace(inputEmail, expresion, string.Empty).Length == 0)
                    {
                        // If exists already..
                        if (Collections.emailList.Contains(inputEmail))
                        {
                            MessageBox.Show(del1.PublishMessage("Sorry this email exists!"));
                        }
                        else
                        {
                            emailSubscription emailSubscription1 = new emailSubscription(inputEmail);
                            emailSubscription1.Subscribe(del1, inputEmail);
                            MessageBox.Show(del1.PublishMessage("Congrats! Your email has been added!"));
                        }
                    }
                    else
                    {
                        MessageBox.Show("something didn't work");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address");
                }
                
            }
            else if (checkBoxMobile.Checked)
            {
                string expresion;
                expresion = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
                if (Regex.IsMatch(inputPhone,expresion ))
                {
                    if (Collections.phoneList.Contains(inputPhone))
                    {
                        MessageBox.Show("Sorry this phone number exists!");
                    }
                    else
                    {
                        PhoneSubscription phoneSub1 = new PhoneSubscription(inputPhone);
                        phoneSub1.Subscribe(del1, inputPhone);
                        MessageBox.Show(del1.PublishMessage("Congrats!your phone number has been added!"));
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Phone number");
                }
            }
            else
            {
                MessageBox.Show("Please choose your way of subscribing (checkBox)");
            }
       }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            string inputPhone = txtPhoneNum.Text;
            string inputEmail = txtEmail.Text;
            Delegate del1 = new Delegate();


            if (checkBoxEmail.Checked)
            {
                string expresion;
                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (Regex.IsMatch(inputEmail, expresion))
                {
                    if (Regex.Replace(inputEmail, expresion, string.Empty).Length == 0)
                    {
                        if (Collections.emailList.Contains(inputEmail))
                        {
                            emailSubscription emailSub1 = new emailSubscription(inputEmail);
                            emailSub1.Unsubscribe(del1,inputEmail);
                            MessageBox.Show("Congrats!your phone number has been added!");
                        }
                        else
                        {
                            MessageBox.Show("Sorry, your email does not exist");
                        }

                    }
                    else
                    {
                        MessageBox.Show("something didn't work");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address");
                }
            }
            else if (checkBoxMobile.Checked)
            {
                string expresion;
                expresion = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
                if (Regex.IsMatch(inputPhone, expresion))
                {
                    
                    if (Collections.phoneList.Contains(inputPhone))
                    {
                        PhoneSubscription phoneSub1 = new PhoneSubscription(inputPhone);
                        phoneSub1.Unsubscribe(del1, inputPhone);
                        MessageBox.Show("Your phone exists, it was deleted");
                    }
                    else
                    {
                        MessageBox.Show("Sorry, your phone does not exist");
                    }
                }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Phone number");
                }
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
    }


