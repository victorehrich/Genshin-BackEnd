using AutoMapper;
using GenshinApplication.DataContext.Interfaces;
using GenshinApplication.Repositories;
using GenshinApplication.Repositories.Interfaces;

namespace GenshinApplication.DataContext
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private bool disposed = false;

        private readonly DataBaseContext _context;

        public UserRepository usersRepository = null;

        public CharactersRepository charactersRepository = null;

        public ArtifactsRepository artifactsRepository = null;

        public WeaponRepository weaponRepository = null;

        public BuildRepository buildRepository = null;

        public ConstelationRepository constelationRepository = null;


        public UnitOfWork(DataBaseContext context)
        {
            _context = context;
        }


        public CharactersRepository CharactersRepository
        {
            get
            {
                if (charactersRepository == null)
                {
                    charactersRepository = new CharactersRepository(_context);
                }
                return charactersRepository;
            }
        }

        public UserRepository UsersRepository
        {
            get
            {
                if (usersRepository == null)
                {
                    usersRepository = new UserRepository(_context);
                }
                return usersRepository;
            }
        }

        public WeaponRepository WeaponRepository
        {
            get
            {
                if (weaponRepository == null)
                {
                    weaponRepository = new WeaponRepository();
                }
                return weaponRepository;
            }
        }

        public BuildRepository BuildRepository
        {
            get
            {
                if (buildRepository == null)
                {
                    buildRepository = new BuildRepository();
                }
                return buildRepository;
            }
        }

        public ArtifactsRepository ArtifactsRepository
        {
            get
            {
                if (artifactsRepository == null)
                {
                    artifactsRepository = new ArtifactsRepository();
                }
                return artifactsRepository;
            }
        }

        public ConstelationRepository ConstelationRepository
        {
            get
            {
                if (constelationRepository == null)
                {
                    constelationRepository = new ConstelationRepository(_context);
                }
                return constelationRepository;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Rollback()
        {

        }
    }
}
