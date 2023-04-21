using AutoMapper;
using GenshinApplication.Interfaces.Services;
using GenshinApplication.Models;
using GenshinApplication.Models.DTO.GET;
using GenshinApplication.Models.DTO.POST;
using GenshinApplication.Repositories.Interfaces;

namespace GenshinApplication.Services
{
    public class ArtifactsService : IArtifactsService
    {
        private readonly IUnitOfWork _repositoryUoW;
        private readonly IMapper _mapper;
        public ArtifactsService(IUnitOfWork repositoryUoW, IMapper mapper)
        {
            _repositoryUoW = repositoryUoW;
            _mapper = mapper;
        }

        public Guid Create(ArtifactsPostDTO artifactsPostDTO)
        {
            try
            {
                //TO DO bloquear cadastro de dois item com o mesmo tipo, em um set
                //Ideia --> criar uma tabela pro set do artefato (id, efeito 1, efeito 2, nome) e uma pro item do set (id, tipo, nome, setId)
                //ai, antes de inserir, checa se ja existe um item, para aquele id de set, que seja do mesmo tipo.
                Artifacts artifact = _mapper.Map<ArtifactsPostDTO, Artifacts>(artifactsPostDTO);
                _repositoryUoW.ArtifactsRepository.Create(artifact);
                _repositoryUoW.Commit();
                return artifact.ArtifactsId;
            }
            catch(Exception e)
            {
                _repositoryUoW.Rollback();
                throw new Exception(e.Message);
            }

        }

        public List<Artifacts> GetAll()
        {
            try
            {
                List<Artifacts> artifacts = _repositoryUoW.ArtifactsRepository.GetAll();
                return artifacts;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
