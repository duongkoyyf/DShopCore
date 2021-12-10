using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DShopCore.ViewModels.Common
{
    public class PagingRequestBase
    {
        public int PageIndex { set; get; }

        public int PageSize { get; set; }
    }
}
