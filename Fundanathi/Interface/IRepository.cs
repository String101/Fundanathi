using System.Linq.Expressions;

namespace Fundanathi.Interface
{
    public interface IRepository<T> where T : class 
    {
        T Get(Expression<Func<T, bool>>? filter, string? includeProperties = null);
    }
  
}
