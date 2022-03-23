using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.DTOs.Mappers
{
    public static class UserMapper
    {
        public static IEnumerable<UserDTO> GetUsers(IEnumerable<User> users)
        {
            IEnumerable<UserDTO> userDTOs = users.Select(user =>
            new UserDTO()
            {
                UserId = user.UserId,
                EMail = user.EMail,
                Name = user.Name,
                InstagramHandle = user.InstagramHandle
            });
            return userDTOs;
        }
        public static UserDTO GetUser(User user)
        {
            UserDTO userDTO = new()
            {
                UserId = user.UserId,
                EMail = user.EMail,
                Name = user.Name,
                InstagramHandle = user.InstagramHandle
            };
            return userDTO;
        }
    }
}
