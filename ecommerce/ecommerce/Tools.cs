﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class Tools
    {

        public static User LoginRetry(string mail, string passwd, Central centrale)
        {
            User user = null;

            try
            {
                user = centrale.Login(mail, passwd);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Wrong email or password, please try again");
                Console.Write("Enter email: ");
                mail = Console.ReadLine();
                Console.Write("Enter password: ");
                passwd = Console.ReadLine();
                LoginRetry(mail, passwd, centrale);
            }

            return user;
        }
    }
}
