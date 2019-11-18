using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    class Order
    {
        public Client Client { get; set; }
        public Vendor Vendor { get; set; }
        public Product Article { get; set; }
        public int Quantity { get; set; }
        public bool Completed { get; set; }

        public Order()
        {

        }
    }
}
