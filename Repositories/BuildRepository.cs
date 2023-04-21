using GenshinApplication.DataContext;
using GenshinApplication.Models;
using GenshinApplication.Repositories.Interfaces;

namespace GenshinApplication.Repositories
{
    public class BuildRepository : Repository<Build>, IBuildRepository
    {
        private readonly DataBaseContext _context;

        public BuildRepository(DataBaseContext context) : base(context)
        {
            _context = context;
        }
        public Guid Create(Build build)
        {
            return new Guid();
        }
    }
}