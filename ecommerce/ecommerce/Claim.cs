using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class Claim
    {
        public string Text { get; set; }
        public Client Client { get; set; }

        public Claim(string text, Client client)
        {
            Text = text;
            Client = client;
        }
    }
}
