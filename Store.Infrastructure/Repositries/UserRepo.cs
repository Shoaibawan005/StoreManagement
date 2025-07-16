using Store.Domain.Entities;
using Store.Domain.Models;
using Store.Infrastructure.IRepositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.Repositries
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _context;

        public UserRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }
        public UserModel? GetUserDetail(int id)
        {
            var user = _context.Users.FirstOrDefault( x => x.Id == id );
            if (user == null) {
                return null;
            }

            return new UserModel
            {
                Name = user.Name,
                Phone_Num = user.Phone_Num,
                Age = user.Age
            };

        }

        public User AddUser(UserModel userModel)
        {
            var user = new User
            {
                Name = userModel.Name,
                Phone_Num = userModel.Phone_Num,
                Age = userModel.Age
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
            
        }

        public string? DeleteUser(int id)
        {

            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            if (user == null) {
                return "User Doesn't Exist.";
            }

            _context.Users.Remove(user);

            return "User Deleted Successfully.";
        }
    }
}
