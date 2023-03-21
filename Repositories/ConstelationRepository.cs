using GenshinApplication.Models;
using GenshinApplication.Repositories.Interfaces;
using GenshinApplication.DataContext;
using Microsoft.EntityFrameworkCore;
using GenshinApplication.Models.DTO.POST;
using AutoMapper;

namespace GenshinApplication.Repositories
{
    public class ConstelationRepository : IConstelationRepository
    {
        private DataBaseContext _context;
        private readonly IMapper _mapper;
        public ConstelationRepository(DataBaseContext context)
        {
            _context = context;
        }

        public Constelation AddConstelation(Guid charactersId, Constelation constelation)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Constelation> GetAllConstelations(Guid charactersId)
        {
            throw new NotImplementedException();
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
