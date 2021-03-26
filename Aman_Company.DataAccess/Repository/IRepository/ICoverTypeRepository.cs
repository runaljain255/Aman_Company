using Aman_Company.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aman_Company.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository:IRepository<CoverType>
    {
        void Update(CoverType coverType);

    }
}
