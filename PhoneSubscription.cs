using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class PhoneSubscription

    {
        private String cellPhone;

        public PhoneSubscription(string cellPhone)
        {
            this.cellPhone = cellPhone;
        }


        public PhoneSubscription() { }

        public void setMobile(String phone)
        {
            cellPhone = phone;
        }

        public String getMobile()
        {
            return cellPhone;
        }

        private string sendMessage(string msg)
        {
           return "The message " + "\"" + msg + "\" has already texted to " + cellPhone;
        }

        public void Subscribe(Delegate pub,string phoneNumber)
        {

            Collections.phoneList.Add(phoneNumber);
            pub.publishmsg += sendMessage;
        }
        public void Unsubscribe(Delegate pub, string phoneNumber)
        {
            Collections.phoneList.Remove(phoneNumber);
            pub.publishmsg -= sendMessage;
        }
      
    }
}
