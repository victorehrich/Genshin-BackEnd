using AutoMapper;
using GenshinApplication.Repositories;
using GenshinApplication.Repositories.Interfaces;
using GenshinApplication.Services.Interfaces;

namespace GenshinApplication.Services
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly IUnitOfWork _repositoryUoW;
        private readonly IMapper _mapper;

        public UnitOfWorkService(IUnitOfWork repositoryUoW, IMapper mapper)
        {
            _repositoryUoW = repositoryUoW;
            _mapper = mapper;
        }

        public CharactersService charactersService = null;
        public BuildService buildService = null;
        public ArtifactsService artifactsService = null;

        public CharactersService CharactersService
        {
            get
            {
                if (charactersService == null)
                {
                    charactersService = new CharactersService(_repositoryUoW, _mapper);
                }
                return charactersService;
            }
        }
        public BuildService BuildService
        {
            get
            {
                if (buildService == null)
                {
                    buildService = new BuildService(_repositoryUoW, _mapper);
                }
                return buildService;
            }
        }
        public ArtifactsService ArtifactsService
        {
            get
            {
                if (artifactsService == null)
                {
                    artifactsService = new ArtifactsService(_repositoryUoW, _mapper);
                }
                return artifactsService;
            }
        }

    }
}
