using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Entities;
using UserApp.Infrastructure.Repository;

namespace UserApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task AddUser(User user)
        {
            await userRepository.AddUser(user);
        }

        public async Task DeleteUser(int id)
        {
            await userRepository.DeleteUser(id);
        }

        public async Task<IList<User>> GetAllUser()
        {
            return await userRepository.GetAllUsers();
        }

        public async Task<User> GetUserById(int id)
        {
            return await userRepository.GetUserById(id);
        }

        public async Task UpdateUser(User user)
        {
            await userRepository.UpdateUser(user);
        }
    }
}
