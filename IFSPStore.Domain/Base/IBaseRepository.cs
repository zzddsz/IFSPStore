﻿namespace IFSPStore.Domain.Base
{
    public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
    {
        void ClearChangeTracker();
        void AttachObject(object obj);
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(object obj);
        IList<TEntity> Select(IList<string>? includes = null);
        TEntity SelectById(int id, IList<string>? includes = null);
    }
}