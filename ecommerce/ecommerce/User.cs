using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class User
    { 
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public bool Confirmed { get; set; }
        public void ConfirmAccount(string confirmationString)
        {
            throw new NotImplementedException();
        }

        public User(string name, string mail, string password)
        {
            Name = name;
            Mail = mail;
            Password = password;
            Confirmed = true;
        }
    }
}
