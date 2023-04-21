using GenshinApplication.Models;
using GenshinApplication.Repositories.Interfaces;
using GenshinApplication.DataContext;


namespace GenshinApplication.Repositories
{
    public class ConstelationRepository : Repository<Constelation>, IConstelationRepository
    {
        private readonly DataBaseContext _context;

        public ConstelationRepository(DataBaseContext context) : base(context)
        {
            _context = context;
        }

        public Constelation AddConstelation(Guid charactersId, Constelation constelation)
        {
            _context.Constelation.Add(constelation);

            return constelation;
        }

        public IEnumerable<Constelation> GetAllCharacterConstelations(Guid charactersId)
        {
            var query = from c in _context.Constelation
                        where c.Characters.CharactersId.Equals(charactersId)
                        select c;
            List<Constelation> constellations = new List < Constelation >(query);

            return constellations;
        }

        public Constelation GetConstelationById(Guid charactersId, Guid constelationId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCharacters(Guid charactersId, Guid constelationId)
        {
            throw new NotImplementedException();
        }
    }
}
