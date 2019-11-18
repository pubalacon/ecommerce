using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class User
    { 
        public string Nom { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public bool Valide { get; set; }
        public void ConfirmAccount(string confirmationString)
        {
            throw new NotImplementedException();
        }

        public User(string nom, string mail, string password)
        {
            Nom = nom;
            Mail = mail;
            Password = password;
            Valide = true;
        }
    }
}
