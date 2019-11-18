using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    class Session
    {
        public Central Centrale { get; set; }
        public User User { get; set; }

        public Session(Central centrale, User user)
        {
            Centrale = centrale;
            User =  user;
        }
    }
}
