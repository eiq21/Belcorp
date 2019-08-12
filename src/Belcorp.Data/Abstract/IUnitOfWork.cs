using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Belcorp.Data.Abstract
{
    public  interface IUnitOfWork
    {
        IGenericRepository<T> Repository<T>() where T : class;

        Task<int> Commit();

        void Rollback();
    }
}
