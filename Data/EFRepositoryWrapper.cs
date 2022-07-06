using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileZone.Data
{
    public class EFRepositoryWrapper:IRepositoryWrapper
    {
        private IMobileRepository _mobile;
        private ICategoryRepository _category;
        private MobileDbContext _mobileDbContext;
        public EFRepositoryWrapper(MobileDbContext mobileDbContext)
        {
            _mobileDbContext = mobileDbContext;
        }

        public IMobileRepository Mobile
        {
            get
            {
                if(_mobile==null)
                {
                    _mobile = new EFMobileRepository(_mobileDbContext);
                }
                return _mobile;
            }
        }

        public ICategoryRepository Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new EFCategoryRepository(_mobileDbContext);
                }
                return _category;
            }
        }

        public void Save()
        {
            _mobileDbContext.SaveChanges(); ;
        }
    }
}
