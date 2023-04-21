using AutoMapper;
using GenshinApplication.Interfaces.Services;
using GenshinApplication.Models;
using GenshinApplication.Models.DTO.GET;
using GenshinApplication.Models.DTO.POST;
using GenshinApplication.Repositories.Interfaces;

namespace GenshinApplication.Services
{
    public class BuildService : IBuildService
    {
        private readonly IUnitOfWork _repositoryUoW;
        private readonly IMapper _mapper;
        public BuildService(IUnitOfWork repositoryUoW, IMapper mapper)
        {
            _repositoryUoW = repositoryUoW;
            _mapper = mapper;
        }

        public Guid Create(BuildPostDTO buildDto)
        {
            var build = _mapper.Map<BuildPostDTO, Build>(buildDto);
            _repositoryUoW.BuildRepository.Create(build);
            return new Guid();
        }
    }
}
