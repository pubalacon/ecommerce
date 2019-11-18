using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    class Program
    {
        static User LoginRetry(string mail, string passwd, Central centrale)
        {
            User user = null;

            try
            {
                user = centrale.Login(mail, passwd);
            }
            catch (ArgumentNullException e)
            {
                // attention au sens des catch si on en empile plus d'un 
                // (ArgumentNullException est incluse dans ArgumentException)
                Console.WriteLine("Wrong email, try again: ");
                mail = Console.ReadLine();
                LoginRetry(mail, passwd, centrale);
            }
            catch (ArgumentException e) // attention au sens
            {
                Console.Write("Wrong password, try again: ");
                passwd = Console.ReadLine();
                LoginRetry(mail, passwd, centrale);
            }

            return user;
        }

        static void Main(string[] args)
        {
            Central centrale = new Central();
            User user = new User();

            Console.Write("Enter email address: ");
            string mail = Console.ReadLine();
            Console.Write("Enter password: ");
            string passwd = Console.ReadLine();
            user = LoginRetry(mail, passwd, centrale);
        }
    }
}
