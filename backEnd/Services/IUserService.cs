using System;
using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;

namespace backEnd.Services{
    public interface IUserService{
        List<User> GetUsers();
        User GetUserById(int id);
        bool CreateUser(UserDTO user);
        bool UpdateUser(UserDTO user, int id);
        bool DeleteUser(int id);
    }
}