using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp1
{
    public class Signin
    {
        public string Authenticate(string username, string password)
        {
            string msg;
            if ((string.IsNullOrEmpty(username)) || string.IsNullOrEmpty(password))
            {
                msg = "details required";
            }
            else
            {
                if((username == "admin") && (password == "admin"))
                {
                    msg = "Authentication Passed";
                }
                else
                {
                    msg = "Authentication failed";
                }

            }
            return msg;
            
        }
    }
}
