using System;
using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;

namespace backEnd.Services{
    public interface IUserService{
        List<User> GetUsers();
        User GetUserById(int id);
        void CreateUser(UserDTO user);
        void UpdateUser(UserDTO user, int id);
        void DeleteUser(int id);
    }
}