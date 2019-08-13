using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Belcorp.Data.Abstract
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>, IUnitOfWork
     where TContext :DbContext,IDisposable 
    {
        private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();
        public Dictionary<Type, object> Repositories { get { return _repositories; } set { Repositories = value; } }

        public TContext Context { get; }

        public UnitOfWork(TContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<int> Commit()
        {
            return await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            if (Repositories.Keys.Contains(typeof(T)))
            {
                return Repositories[typeof(T)] as IGenericRepository<T>;
            }

            IGenericRepository<T> repo = new GenericRepository<T>(Context);
            Repositories.Add(typeof(T), repo);
            return repo;
        }

        public void Rollback()
        {
            Context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
        }
    }
}
