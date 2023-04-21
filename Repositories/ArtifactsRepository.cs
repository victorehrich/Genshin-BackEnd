using GenshinApplication.DataContext;
using GenshinApplication.Models;
using GenshinApplication.Repositories.Interfaces;

namespace GenshinApplication.Repositories
{
    public class ArtifactsRepository : IArtifactsRepository
    {
        private readonly DataBaseContext _context;

        public ArtifactsRepository(DataBaseContext context)
        {
            _context = context;
        }

        public void Create(Artifacts artifact)
        {
            _context.Artifacts.Add(artifact);
        }

        public List<Artifacts> GetAll()
        {
            List<Artifacts> result = _context.Artifacts.ToList();
            return result;
        }

        public Artifacts GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}