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
                        //if (emailSubscription1.CheckIfExists(inputEmail)==true)
                        if (Collections.emailList.Contains(inputEmail))
                        {
                            MessageBox.Show("Sorry this email exists!");
                        }
                        else
                        {
                            emailSubscription emailSubscription1 = new emailSubscription(inputEmail);
                            emailSubscription1.Subscribe(del1, inputEmail);
                            MessageBox.Show("Congats! Your email has been added.");
                        }
                        //del1.PublishMessage("New Notifications!");
                        // Console.ReadLine();
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
                    if (Collections.phoneList.Contains(inputEmail))
                    {
                        MessageBox.Show("Sorry this email exists!");
                    }
                    else
                    {PhoneSubscription phoneSub1 = new PhoneSubscription(inputPhone);
                        phoneSub1.Subscribe(del1, inputPhone);
                        MessageBox.Show("Congats! Your email has been added.");
                    }
                    //del1.PublishMessage("New Notifications!");
                    //Console.ReadLine();
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
                        emailSubscription emailSubscription1 = new emailSubscription(inputEmail);
                        if(emailSubscription1.CheckIfExists(inputEmail))
                        {

                            emailSubscription1.Unsubscribe(del1);
                            MessageBox.Show("Your email exists, it was deleted");
                        }
                        else
                        {
                            MessageBox.Show("Sorry, your email does not exist");
                        }
                      
                        //del1.PublishMessage("New Notifications!");
                        //Console.ReadLine();

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
                    PhoneSubscription phoneSub1 = new PhoneSubscription(inputPhone);
                    if (phoneSub1.CheckIfExists(inputPhone))
                    {
                        phoneSub1.Unsubscribe(del1);
                        MessageBox.Show("Your phone exists, it was deleted");
                    }
                    else
                    {
                        MessageBox.Show("Sorry, your phone does not exist");
                    }
                }
                    //del1.PublishMessage("New Notifications!");
                    //Console.ReadLine();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Phone number");
                }
            }
        }
    }


