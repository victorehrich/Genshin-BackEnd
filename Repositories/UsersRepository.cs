using GenshinApplication.Models;
using GenshinApplication.Repositories.Interfaces;
using GenshinApplication.DataContext;
using Microsoft.EntityFrameworkCore;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DataBaseContext _context;

        public UserRepository(DataBaseContext context)
        {
            _context = context;
        }

        public void DeleteUser(Guid userId)
        {
                Users user = this.GetUsersByID(userId);
                _context.Users.Remove(user);
        }

        public IEnumerable<Users> GetStudents()
        {
            return _context.Users.ToList();
        }

        public Users GetUsersByID(Guid userId)
        {
            Users user = _context.Users.Find(userId);
            return user;
        }

        public Users InsertUser(Users user)
        {
            _context.Users.Add(user);
            return user;
        }

        public void UpdateUser(Users users)
        {
            _context.Entry(users).State = EntityState.Modified;
        }
    }
}
