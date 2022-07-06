using MobileZone.Data.DataAccess;
using MobileZone.Models;
using System.Collections.Generic;
using System.Linq;

namespace MobileZone.Data
{
    public interface IMobileRepository: IRepositoryBase<Mobile>
    {
        IEnumerable<Mobile> GetMobileWithCategoryDetailsOptions(QueryOptions<Mobile> options);
    }
}
