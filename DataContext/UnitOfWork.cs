using GenshinApplication.DataContext.Interfaces;

namespace GenshinApplication.DataContext
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataBaseContext _context;
        public UnitOfWork(DataBaseContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {

        }
    }
}
