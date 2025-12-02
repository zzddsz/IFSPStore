using IFSPStore.Domain.Base;
using IFSPStore.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected IFSPStoreContext _mySqlContext;

        public BaseRepository(IFSPStoreContext mySqlContext)
        {
            _mySqlContext = mySqlContext;
        }

        public void AttachObject(object obj)
        {
            _mySqlContext.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _mySqlContext.ChangeTracker.Clear();
        }

        public void Insert(TEntity obj)
        {
            _mySqlContext.Set<TEntity>().Add(obj);
            _mySqlContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _mySqlContext.Entry(obj).State = EntityState.Modified;
            _mySqlContext.SaveChanges();
        }

        public void Delete(object id)
        {
            // Busca o item pelo ID antes de tentar remover
            var entity = Select((int)id);
            if (entity != null)
            {
                _mySqlContext.Set<TEntity>().Remove(entity);
                _mySqlContext.SaveChanges();
            }
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var dbContext = _mySqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList();
        }

        public TEntity Select(int id, IList<string>? includes = null)
        {
            var dbContext = _mySqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            // Implementação correta
            return dbContext.FirstOrDefault(x => x.Id == id);
        }

        public TEntity SelectById(int id, IList<string>? includes = null)
        {
            return Select(id, includes);
        }
    }
}