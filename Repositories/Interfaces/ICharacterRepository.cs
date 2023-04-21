using GenshinApplication.Models;
using GenshinApplication.Models.DTO.GET;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Repositories.Interfaces
{
    public interface ICharactersRepository
    {
        IEnumerable<Characters> GetAllCharacters();
        IEnumerable<SummarizedCharacters> GetAllResumedCharactes();
        Characters GetById(Guid charactersId);
        Characters GetCharacterByName(string characterName);
        Characters AddCharacter(Characters charactersPostDto);
        void DeleteCharacters(Guid charactersId);
        void UpdateCharacters(Characters Characters);
    }
}
