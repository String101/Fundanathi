using Fundanathi.Data;
using Fundanathi.Interface;

namespace Fundanathi.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly SQLiteDbContext _db;
        

        public IApplicationUser User { get; private set; }

        public UnitOfWork(SQLiteDbContext db)
        {
            _db = db;
            User = new ApplicationUserRepo(_db);
        }
    }
}
