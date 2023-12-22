using Fundanathi.Models;
using System.Linq.Expressions;

namespace Fundanathi.Interface
{
    public interface ISubject
    {
        IEnumerable<Subjects> GetAll(Expression<Func<Subjects, bool>>? filter = null, string? includeProperties = null);
        Subjects Get(Expression<Func<Subjects, bool>>? filter, string? includeProperties = null);
        void Add(Subjects entity);
        bool Any(Expression<Func<Subjects, bool>>? filter);
        void Remove(Subjects entity);
        void Update(Subjects entity);
        void Save();
    }
}
