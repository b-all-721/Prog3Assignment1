using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class PublicationClass
    {
        private String publicationString;
        public PublicationClass(string publication)
        {
            this.publicationString = publication;
        }

        public PublicationClass() { }

        public void setEmailAddr(String publication)
        {
            this.publicationString = publication;
        }

        public String getEmailAddr()
        {
            return publicationString;
        }

        public string sendPublication(string msg)
        {
            string collection = null;
            Collections.emailList.Add("holly@gmail.com");
            Collections.emailList.Add("holms@rogers.ca");

            foreach (var item in Collections.emailList)
            {
               collection += msg + publicationString + " was sent to " + item + "\n";
            }
            return collection;
        }

        public void Publish(Delegate pub)
        {
            pub.publishmsg += sendPublication;
        }
    }
}
