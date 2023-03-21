using GenshinApplication.Models;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Repositories.Interfaces
{
    public interface IConstelationRepository
    {
        IEnumerable<Constelation> GetAllConstelations(Guid charactersId);
        Constelation GetConstelationById(Guid charactersId, Guid constelationId);
        Constelation AddConstelation(Guid charactersId, Constelation constelation);
        void UpdateCharacters(Guid charactersId, Guid constelationId);
    }
}
