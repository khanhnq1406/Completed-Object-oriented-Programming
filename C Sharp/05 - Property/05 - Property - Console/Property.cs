using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyConsole
{
    class Property
    {
        private string username;
        private string password;
        public Property(string password)
        {
            this.password = password;
        }
        public string username_prop
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string password_prop
        {
            get
            {
                return password;
            }
        }
    }
}
