using GenshinApplication.Models;
using GenshinApplication.Repositories;
using GenshinApplication.Repositories.Interfaces;

namespace GenshinApplication.DataContext.Interfaces
{
    public interface IUnitOfWork
    {
        UserRepository UsersRepository { get; }
        CharactersRepository CharactersRepository { get; }
        ArtifactsRepository ArtifactsRepository { get; }
        WeaponRepository WeaponRepository { get; }
        BuildRepository BuildRepository { get; }
        ConstelationRepository ConstelationRepository { get; }

        void Commit();
        void Rollback();
    }
}
