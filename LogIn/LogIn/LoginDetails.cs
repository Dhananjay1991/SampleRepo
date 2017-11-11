using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn
{
    [Serializable]
    class LoginDetails
    {
        string user_name;
        string pwd;
        public LoginDetails(string name,string pwd)
        {
            user_name = name;
            this.pwd = pwd;
        }
        public string User_Name
        {
            get
            {
                return user_name;
            }
            set
            {
                user_name = value;
            }
        }
        public string Password
        {
            get
            {
                return pwd;
            }
            set
            {
                pwd = value;
            }
        }
    }

}
