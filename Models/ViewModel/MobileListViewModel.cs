using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileZone.Models.ViewModel
{
    public class MobileListViewModel
    {
        public IEnumerable<Mobile> Mobiles { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
