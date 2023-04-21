using GenshinApplication.Models;
using GenshinApplication.Models.DTO.GET;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Repositories.Interfaces
{
    public interface IArtifactsRepository
    {
        void Create(Artifacts artifact);
        Artifacts GetById(Guid id);
        List<Artifacts> GetAll();
    }
}
