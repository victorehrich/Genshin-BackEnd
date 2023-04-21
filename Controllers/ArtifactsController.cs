using AutoMapper;
using GenshinApplication.Models;
using GenshinApplication.Models.DTO.GET;
using GenshinApplication.Models.DTO.POST;
using GenshinApplication.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GenshinApplication.Controllers
{
    [Route("api/v1/artifacts")]
    public class ArtifactsController : ControllerBase
    {
        private readonly IUnitOfWorkService _serviceUoW;

        public ArtifactsController(IUnitOfWorkService serviceUoW)
        {
            _serviceUoW = serviceUoW;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public IActionResult CreateArtifact(ArtifactsPostDTO artifactsPostDTO)
        {
            try
            {
                _serviceUoW.ArtifactsService.Create(artifactsPostDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Characters>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            try
            {
                var Artifacts = _serviceUoW.ArtifactsService.GetAll();
                return Ok(Artifacts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}