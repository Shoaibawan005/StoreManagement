using Store.Domain.Entities;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.IServices
{
    public interface IUserSRV
    {
        public UserModel? GetUserDetail(int id);

        public List<User> GetAllUsers();

        public User AddUser(UserModel userModel);

        public string? DeleteUser(int id);
    }
}
