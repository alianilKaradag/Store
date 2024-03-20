using System.Linq.Expressions;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        public IQueryable<T> FindAll(bool trackChanges);
        public T? FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        public void Create(T entity);
    }
}