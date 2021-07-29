using System;
using System.Collections.Generic;
using System.Linq;
using backEnd.Models;
using backEnd.Models.DTO;
using backEnd.Services;

namespace backEnd.Services.Implemention
{
    public class UserService : IUserService
    {
        private DataContext _dataContext;
        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<User> GetUsers()
        {
            return _dataContext.Users.ToList();
        }
        public User GetUserById(int id)
        {
            return _dataContext.Users.Where(s => s.UserId == id).FirstOrDefault();
        }
        public void CreateUser(UserDTO user)
        {
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var newUser = new User()
                {
                    Name = user.Name,
                    Password = user.Password,
                    IsAdmin = user.IsAdmin
                };
                _dataContext.Users.Add(newUser);
                _dataContext.SaveChanges();
                transation.Commit();
            }
            catch(Exception)
            {
                return;
            }
        }

        public void UpdateUser(UserDTO user, int id)
        {
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var updateUser = _dataContext.Users.Where(u => u.UserId == id).FirstOrDefault();
                updateUser.Name = user.Name;
                updateUser.Password = user.Password; 

                _dataContext.SaveChanges();
                transation.Commit();
            }
            catch(Exception)
            {
                return;
            }
        }

        public void DeleteUser(int id)
        {
            
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var user = _dataContext.Users.Where(u => u.UserId == id).FirstOrDefault();
                _dataContext.Users.Remove(user);
                _dataContext.SaveChanges();
                transation.Commit();
            }
            catch(Exception)
            {
                return;
            }
        }
    }
}