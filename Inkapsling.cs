using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_OOP
{
    public class Login
    {
        private string userName;
        private string password;

        public Login(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public string Username
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }
}
