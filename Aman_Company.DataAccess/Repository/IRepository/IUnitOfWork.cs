using System;
using System.Collections.Generic;
using System.Text;

namespace Aman_Company.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get;  }
        ICoverTypeRepository CoverType { get;  }
        ISP_Call SP_Call { get;  }

        void Save();

    }
}
