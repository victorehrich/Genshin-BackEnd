using AutoMapper;
using GenshinApplication.Models;
using GenshinApplication.Models.DTO.GET;
using GenshinApplication.Models.DTO.POST;
using GenshinApplication.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GenshinApplication.Controllers
{
    [Route("api/v1/characters")]
    public class CharactersController : ControllerBase
    {
        private readonly IUnitOfWorkService _serviceUoW;

        public CharactersController(IUnitOfWorkService serviceUoW)
        {
            _serviceUoW = serviceUoW;
        }
        /// <summary>
        /// Creates a new character
        /// </summary>
        /// <param name="charactersPostDto"></param>
        /// <returns></returns>
        [ProducesResponseType(typeof(Characters), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public IActionResult CreateCharacter([FromBody]CharactersPostDto charactersPostDto)
        {
            try
            {
                Characters character = _serviceUoW.CharactersService.Create(charactersPostDto);
                return CreatedAtAction(nameof(GetCharacterFullInfo), character);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet]
        [Route("fullInfos/{characterName}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Characters>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public IActionResult GetCharacterFullInfo(string characterName)
        {
            try
            {
                var characters = _serviceUoW.CharactersService.GetCharacterFullInfo(characterName);
                //return CustomResponse(characters);
                return Ok(characters);
            }
            catch (Exception ex)
            {
                //return CustomResponse(ex);
                return BadRequest(ex);

            }
        }
        [HttpGet]
        [Route("GetCharactersSummerized")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<SummarizedCharacters>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllCharactersHome()
        {
            try
            {
                var characters = _serviceUoW.CharactersService.GetCharactersSummerized();
                return Ok(characters);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        /*[HttpPost]
        [Route("addBuild")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddBuild([FromBody] BuildPostDTO build, Guid characterId)
        {
            try
            {
                _serviceUoW.CharactersService.AddBuild(build, characterId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }*/
    }
}