using AutoMapper;
using GenshinApplication.DataContext.Interfaces;
using GenshinApplication.Models;
using GenshinApplication.Models.DTO.POST;
using Microsoft.AspNetCore.Mvc;

namespace GenshinApplication.Controllers
{
    [Route("api/v1/characters")]
    public class CharactersController : ControllerBase
    {
        private readonly IUnitOfWork _repositoryUoW;
        private readonly IMapper _mapper;
        public CharactersController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repositoryUoW = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateCharacter(CharactersPostDto charactersPostDto)
        {
            try
            {
                Characters character = _mapper.Map<CharactersPostDto, Characters>(charactersPostDto);
                _repositoryUoW.CharactersRepository.AddCharacter(character);
                _repositoryUoW.Commit();
                return Ok(character);
            }
            catch (Exception ex)
            {
                _repositoryUoW.Rollback();
                return BadRequest(ex);
            }
        }
        [HttpGet]
        public IActionResult GetAllCharacters()
        {
            try
            {
                var characters = _repositoryUoW.CharactersRepository.GetAllCharacters();
                _repositoryUoW.Commit();
                return Ok(characters);
            }
            catch (Exception ex)
            {
                _repositoryUoW.Rollback();
                return BadRequest(ex);
            }
        }
    }
}