using System.Linq.Expressions;

namespace TreinoEF.Infra.Repositories.Interfaces
{
    public interface IBaseRepositories<T, TKey>
    {
        Task<T> Get(TKey id);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllAsync();
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        Task SaveChanges();


        /*
         * 
         * A partir do dotnet 8 é permitido declarar metodos default.
        int DeleteAll(int Id)
        {
            return Id;
        }
         */
    }
}
