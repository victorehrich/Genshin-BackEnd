using GenshinApplication.Models;
using GenshinApplication.Repositories;

namespace GenshinApplication.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        CharactersRepository CharactersRepository { get; }
        ArtifactsRepository ArtifactsRepository { get; }
        WeaponRepository WeaponRepository { get; }
        BuildRepository BuildRepository { get; }
        ConstelationRepository ConstelationRepository { get; }

        void Commit();
        void Rollback();
    }
}
