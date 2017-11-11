using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn
{
    [Serializable]
    public class ContactInfo
    {
        string name, contact_no;
        public ContactInfo(string name,string contact_no)
        {
            this.name = name;
            this.contact_no = contact_no;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name= value;
            }
        }
        public string Contact
        {
            get
            {
                return contact_no;
            }
            set
            {
                contact_no = value;
            }
        }

    }
}
