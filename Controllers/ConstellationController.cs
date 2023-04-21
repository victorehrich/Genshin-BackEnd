using AutoMapper;
using GenshinApplication.Models;
using GenshinApplication.Models.DTO.POST;
using GenshinApplication.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GenshinApplication.Controllers
{
    [Route("api/v1/contellation")]
    public class ConstellationController : ControllerBase
    {
        private readonly IUnitOfWork _repositoryUoW;
        private readonly IMapper _mapper;
        public ConstellationController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repositoryUoW = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateConstellation(ConstelationPostDTO constelationPostDTO)
        {
            try
            {
                Constelation constelation = _mapper.Map<ConstelationPostDTO, Constelation>(constelationPostDTO);
                constelation.Characters = _repositoryUoW.CharactersRepository.GetCharacterById(constelationPostDTO.CharactersId);
                _repositoryUoW.ConstelationRepository.AddConstelation(constelationPostDTO.CharactersId, constelation);
                _repositoryUoW.Commit();
                return Ok(constelationPostDTO);
            }
            catch (Exception ex)
            {
                _repositoryUoW.Rollback();
                return BadRequest(ex);
            }
        }
        [HttpGet]
        public IActionResult GetAllCharactersConstelations(Guid characterId)
        {
            try
            {
                var constellations = _repositoryUoW.ConstelationRepository.GetAllCharacterConstelations(characterId);
                return Ok(constellations);
            }
            catch (Exception ex)
            {
                _repositoryUoW.Rollback();
                return BadRequest(ex);
            }
        }
    }
}