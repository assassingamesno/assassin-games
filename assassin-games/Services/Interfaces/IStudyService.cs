﻿using assassingames_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Services.Interfaces
{
    public interface IUserService
    {
        public User GetUser(Guid userId);
        public IEnumerable<User> GetUsers();
        public void InsertUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(Guid userId);
    }
}
