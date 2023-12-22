using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using Fundanathi.Interface;

using Fundanathi.Data;
using Fundanathi.Models;

namespace Fundanathi.Repositories
{
    public class ApplicationUserRepo: Repository<ApplicationUser>,IApplicationUser
    {
        private readonly SQLiteDbContext _context;

        public ApplicationUserRepo(SQLiteDbContext context):base(context)
        {
            _context = context;
        }
        
    }
}
