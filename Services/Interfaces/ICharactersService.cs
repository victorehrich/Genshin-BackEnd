using GenshinApplication.Models;
using GenshinApplication.Models.DTO.GET;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Interfaces.Services
{
    public interface ICharactersService
    {
        public Characters Create(CharactersPostDto character);
        public FullCharactersInfo GetCharacterFullInfo(string characterName);
        public List<SummarizedCharacters> GetCharactersSummerized();
    }
}
