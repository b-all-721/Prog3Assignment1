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
        public void Unsubscribe(Delegate pub)
        {
            pub.publishmsg -= sendMessage;
        }
        public bool CheckIfExists(string phone)
        {
            //bool output = true;
            ////foreach (string item in pohneNumList)
            ////{
            //    if (item.Equals(phone))
            //    {
            //        return output = true;

            //    }
            //    else
            //    {
            //        return output = false;

            //    }

            //}
            if (Collections.phoneList.Contains(phone))
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
