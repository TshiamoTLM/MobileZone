using MobileZone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileZone.Data
{
    public class EFCategoryRepository:EFRepositoryBase<Category>, ICategoryRepository
    {
        public EFCategoryRepository(MobileDbContext mobileDbContext):base(mobileDbContext)
        {

        }
    }
}
