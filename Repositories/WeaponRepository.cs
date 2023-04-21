using GenshinApplication.DataContext;
using GenshinApplication.Models;
using GenshinApplication.Repositories.Interfaces;

namespace GenshinApplication.Repositories
{
    public class WeaponRepository : IWeaponRepository
    {
        private readonly DataBaseContext _context;

        public WeaponRepository(DataBaseContext context)
        {
            _context = context;
        }

        public Guid Create(Weapon weapon)
        {
            _context.Weapons.Add(weapon);
            return weapon.WeaponId;
        }

        public Guid CreateArtifact(Artifacts artifact)
        {
            _context.Artifacts.Add(artifact);
            return artifact.ArtifactsId;
        }

        public List<Weapon> GetAll()
        {
            throw new NotImplementedException();
        }

        public Artifacts GetArtifact(Guid id)
        {
            Artifacts artifact = _context.Artifacts.Find(id);
            return artifact;
        }

        public Weapon GetById(Guid id)
        {
            Weapon weapon = _context.Weapons.Find(id);
            return weapon;
        }
    }
}