using GenshinApplication.Models;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<Users> GetStudents();
        Users GetUsersByID(Guid userId);
        Users InsertUser(Users Users);
        void DeleteUser(Guid userId);
        void UpdateUser(Users Users);
    }
}
