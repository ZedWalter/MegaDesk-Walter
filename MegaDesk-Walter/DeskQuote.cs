using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Walter
{
    internal class DeskQuote
    {
        public string CustomerName { get; set; }

        public string Shipping { get; set; }

        public int GetQuotePrice() 
        {
            int price = 0;
            return price;
        }
    }
}
