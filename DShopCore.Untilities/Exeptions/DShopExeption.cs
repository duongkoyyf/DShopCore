using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DShopCore.Untilities.Exeptions
{
    public class DShopExeption:Exception
    {
        public DShopExeption()
        {

        }

        public DShopExeption(string message) :base(message)
        {

        }

        public DShopExeption(string message, Exception inner):base(message, inner)
        {

        }
    }
}
