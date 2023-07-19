using UserApp.Entities;

namespace UserApp.Services
{
    public interface IUserService
    {
        Task<IList<User>> GetAllUser();
        Task<User> GetUserById(int id);
        Task AddUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
    }
}