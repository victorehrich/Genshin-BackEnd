using GenshinApplication.Models;
using GenshinApplication.Models.DTO.GET;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Repositories.Interfaces
{
    public interface IBuildRepository
    {
        Guid Create(Build build);
    }
}
