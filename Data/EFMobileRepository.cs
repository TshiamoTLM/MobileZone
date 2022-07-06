using Microsoft.EntityFrameworkCore;
using MobileZone.Data.DataAccess;
using MobileZone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileZone.Data
{
    public class EFMobileRepository:EFRepositoryBase<Mobile>, IMobileRepository
    {
        public EFMobileRepository(MobileDbContext mobileDbContext):base(mobileDbContext)
        {    
        }

        public IEnumerable<Mobile> GetMobileWithCategoryDetails()
        {
            return _mobileDbContext.Mobiles
                .Include(c => c.Category);
        }

        public IEnumerable<Mobile> GetMobileWithCategoryDetailsOptions(QueryOptions<Mobile> options)
        {
            IQueryable<Mobile> query = _mobileDbContext.Mobiles 
                .Include(c=>c.Category);

            if (options.HasWhere)
                query = query.Where(options.Where);

            if (options.HasOrderBy)
            {
                if (options.OrderByDirection == "asc")
                    query = query.OrderBy(options.OrderBy);
                else
                    query = query.OrderByDescending(options.OrderBy);
            }
            if (options.HasPaging)
            {
                query = query.Skip((options.PageNumber - 1) * options.PageSize)
                             .Take(options.PageSize);
            }
            return query.ToList();
        }
    }
}
