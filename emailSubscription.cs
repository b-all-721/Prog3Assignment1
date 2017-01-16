using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class emailSubscription
    {

        //List<string> emailList = new List<string>();


        private String emailAddr;
        public emailSubscription(string email)
        {
            this.emailAddr = email;
        }
       

        public void setEmailAddr(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public String getEmailAddr()
        {
            return emailAddr;
        }

        public string sendEmail(string msg)
        {
            return "The message" + "\"" + msg + "\" has already sent to " + emailAddr;
            
        } 

        public void Subscribe(Delegate pub,string email)
        {

            Collections.emailList.Add(email);
            pub.publishmsg += sendEmail;
        }
        public void Unsubscribe(Delegate pub)
        {
            pub.publishmsg -= sendEmail;
        }
         public bool CheckIfExists(string email)
        {
            //bool output = false;
            //foreach (var item in emailList)
            //{
            //    if (item.Equals(email))
            //    {
            //      return output = true;
            //        // break;
            //    }
            //    else
            //    {
            //        return output = false;
            //       // break;
            //    }
            //    return output;
            //}
            //return output;
            if (Collections.emailList.Contains(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
