using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using assassingames_backend.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void DeleteUser(Guid userId)
        {
            _userRepository.DeleteUser(userId);
        }

        public User GetUser(Guid userId)
        {
            return _userRepository.GetUser(userId);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public void InsertUser(User user)
        {
            _userRepository.InsertUser(user);
        }

        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }
    }
}
