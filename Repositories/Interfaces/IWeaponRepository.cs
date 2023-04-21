using GenshinApplication.Models;
using GenshinApplication.Models.DTO.GET;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Repositories.Interfaces
{
    public interface IWeaponRepository
    {
        Guid Create(Weapon weapon);
        Weapon GetById(Guid id);
        List<Weapon> GetAll();

    }
}
