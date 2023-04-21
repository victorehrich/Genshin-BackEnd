using GenshinApplication.Models;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Interfaces.Services
{
    public interface IBuildService
    {
        public Guid Create(BuildPostDTO build);
    }
}
