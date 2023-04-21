using GenshinApplication.Models;
using GenshinApplication.Repositories;
using GenshinApplication.Repositories.Interfaces;
using GenshinApplication.Services;

namespace GenshinApplication.Services.Interfaces
{
    public interface IUnitOfWorkService
    {
        CharactersService CharactersService { get; }
        BuildService BuildService { get; }
        ArtifactsService ArtifactsService { get; }
    }
}
