using GenshinApplication.Models;
using GenshinApplication.Repositories.Interfaces;
using GenshinApplication.DataContext;
using Microsoft.AspNetCore.Mvc;
using GenshinApplication.Models.DTO.GET;

namespace GenshinApplication.Repositories
{
    public class CharactersRepository : Repository<Characters>, ICharactersRepository
    {
        private readonly DataBaseContext _context;

        public CharactersRepository(DataBaseContext context): base(context)
        {
            _context = context;
        }

        public Characters AddCharacter(Characters characters)
        {
            characters.CharactersId = new Guid();
            _context.Characters.Add(characters);
            
            return characters;
        }

        public void DeleteCharacters(Guid charactersId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Characters> GetAllCharacters()
        {            
            List<Characters> characters = _context.Characters.ToList();
            return characters;
        }
        public Characters GetCharacterByName(string characterName)
        {
            var characterQueryble = from c in _context.Characters
                        where c.Name.Equals(characterName)
                        select c;
            Characters characters = characterQueryble.ToArray().FirstOrDefault();
            return characters;
        }
        public Characters GetCharacterById(Guid characterId)
        {
            Characters characters = _context.Characters.Find(characterId);
            return characters;
        }
        public IEnumerable<SummarizedCharacters> GetAllResumedCharactes()
        {
            List<Characters> characters = _context.Characters.ToList();
            List<SummarizedCharacters> charactersHome = new();
            characters.ForEach(character =>
            {
                SummarizedCharacters c = new()
                {
                    Id = character.CharactersId,
                    Name = character.Name,
                    Element = ConvertEnumToString<ElementsEnum>(character.Element),
                    NumberOfStars = ConvertEnumToString<NumberOfStarsEnum>(character.NumberOfStars),
                    WeaponType = ConvertEnumToString<WeaponEnum>(character.WeaponType),
                    Gender = ConvertEnumToString<GenderEnum>(character.Gender),
                    Location = ConvertEnumToString<LocationEnum>(character.Location)
                };
                charactersHome.Add(c);
            });
            return charactersHome;
        }

        public Characters GetById(Guid charactersId)
        {
            var character = _context.Characters.Find(charactersId);
            return character;
        }

        public void UpdateCharacters([FromBody] Characters Characters)
        {
            throw new NotImplementedException();
        }

    }
}
