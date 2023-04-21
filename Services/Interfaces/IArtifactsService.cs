using GenshinApplication.Models;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Interfaces.Services
{
    public interface IArtifactsService
    {
        public Guid Create(ArtifactsPostDTO artifactsPostDTO);
        public List<Artifacts> GetAll();
    }
}
