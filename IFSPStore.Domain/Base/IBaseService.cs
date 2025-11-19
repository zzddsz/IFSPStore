using FluentValidation;
using System.Collections.Generic;
namespace IFSPStore.Domain.Base
{
    public interface IBaseService<TEntity> where TEntity : IBaseEntity
    {
        void AttachObject(object obj);

        TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;

        void Delete(int id);

        ICollection<TEntity> Get();

        TEntity GetById(int id);

        TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;
        object Get<T>();
        T GetById<T>(int id);
    }
}