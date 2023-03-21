using GenshinApplication.Models;
using GenshinApplication.Repositories.Interfaces;
using GenshinApplication.DataContext;
using Microsoft.EntityFrameworkCore;
using GenshinApplication.Models.DTO.POST;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

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

        public Characters GetCharactersById(Guid charactersId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCharacters([FromBody] Characters Characters)
        {
            throw new NotImplementedException();
        }

    }
}
