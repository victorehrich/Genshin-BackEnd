using GenshinApplication.Models;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Repositories.Interfaces
{
    public interface ICharactersRepository
    {
        IEnumerable<Characters> GetAllCharacters();
        Characters GetCharactersById(Guid charactersId);
        Characters AddCharacter(Characters charactersPostDto);
        void DeleteCharacters(Guid charactersId);
        void UpdateCharacters(Characters Characters);
    }
}
