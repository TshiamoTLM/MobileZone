using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileZone.Data
{
    public interface IRepositoryWrapper
    {
        IMobileRepository Mobile { get; }
        ICategoryRepository Category { get; }
        void Save();
    }
}
