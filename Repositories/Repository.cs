using GenshinApplication.DataContext;
using GenshinApplication.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GenshinApplication.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly DataBaseContext _context;
        public Repository(DataBaseContext context)
        {
            _context = context;
        }

    }
}
