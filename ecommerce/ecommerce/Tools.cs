using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class Tools
    {

        public static User LoginRetry(string mail, string password, Central centrale)
        {
            User user = null;

            try
            {
                user = centrale.Login(mail, password);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Wrong email or password, please try again");
                Console.Write("Enter email: ");
                mail = Console.ReadLine();
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                user = LoginRetry(mail, password, centrale);
            }

            return user;
        }
    }
}
