using Store.Application.IServices;
using Store.Domain.Entities;
using Store.Domain.Models;
using Store.Infrastructure.IRepositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Services
{
    public class UserSRV : IUserSRV
    {

        private readonly IUserRepo _userRepo; 
        public UserSRV(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public UserModel? GetUserDetail(int id)
        {
            var user = _userRepo.GetUserDetail(id);

            return user;

        }

        public List<User> GetAllUsers()
        {
            var users = _userRepo.GetAllUsers();
            return users;

        }

        public User AddUser(UserModel userModel)
        {
            if (string.IsNullOrEmpty(userModel.Name) || string.IsNullOrEmpty(userModel.Phone_Num)){
                throw new ArgumentException();
                
            }
            var userObj = _userRepo.AddUser(userModel);

            return userObj;

        }

        public string? DeleteUser(int id)
        {
           var msg = _userRepo.DeleteUser(id);

            return msg;

        }
    }
}
