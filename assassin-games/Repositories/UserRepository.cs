using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void DeleteUser(Guid userId)
        {
            User user = _applicationDbContext.Users.Find(userId);
            _applicationDbContext.Users.Remove(user);
            _applicationDbContext.SaveChanges();
        }

        public User GetUser(Guid userId)
        {
            return _applicationDbContext.Users.Find(userId);
        }

        public IEnumerable<User> GetUsers()
        {
            return _applicationDbContext.Users;
        }

        public void InsertUser(User user)
        {
            _applicationDbContext.Users.Add(user);
            _applicationDbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _applicationDbContext.Users.Update(user);
            _applicationDbContext.SaveChanges();
        }
    }
}
