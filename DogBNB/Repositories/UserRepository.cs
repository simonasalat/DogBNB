using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB_Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DogBNBDbContext _context;
        public UserRepository(DogBNBDbContext context)
        {
            _context = context;
        }

        public User CreateUser(User user)
        {
            var u = new DogBNB_Db.Entities.User
            {
                 Name = user.Name,
                 Surname = user.Surname,
                 Password = user.Password, //TODO: save as hash
                 Email = user.Email,
                 Phone = user.Phone,
                 Gender = user.Gender.ToString()

            };

            _context.Users.Add(u);
            _context.SaveChanges();

            return user;
        }

        public void DeleteUser(int id)//TODO: ApiResponse?
        {
            var user =_context.Users.Where(u => u.Id == id).First();
            _context.Users.Remove(user);
            _context.SaveChanges(); 

        }

        public User GetUserById(int id)
        {
            var u= _context.Users.Where(u => u.Id == id).First();
            _ = Enum.TryParse(u.Gender, out GenderType gender);
            var user = new User
            {
                Name = u.Name,
                Surname = u.Surname,
                Email = u.Email,
                Phone = u.Phone,
                Gender = gender

            };
            return user;
        }

        public List<User> GetUsers()
        {
            var list = _context.Users.ToList();
            var userList = new List<User>();

            foreach(var u in list)
            {
                _ = Enum.TryParse(u.Gender, out GenderType gender);
                var users = new User
                {
                    Name = u.Name,
                    Surname = u.Surname,
                    Email = u.Email,
                    Phone = u.Phone,
                    Gender = gender
                };
                userList.Add(users);
            }

            return userList;
        }

        public List<User> GetUsersByName(string username)
        {
            var list = _context.Users.Where(u=>u.Name==username).ToList();
            var userList = new List<User>();

            foreach (var u in list)
            {
                _ = Enum.TryParse(u.Gender, out GenderType gender);
                var users = new User
                {
                    Name = u.Name,
                    Surname = u.Surname,
                    Email = u.Email,
                    Phone = u.Phone,
                    Gender = gender
                };
                userList.Add(users);
            }

            return userList;
        }

        public User UpdateUser(User user, int id)//TODO:update password?
        {
            var u = _context.Users.Where(u => u.Id == id).First();
            if (u != null)
            {
                u.Name = user.Name;
                u.Surname = user.Surname;
                u.Email = user.Email;
                u.Phone = user.Phone;
                u.Gender = user.Gender.ToString();
            }
           
            return user;
        }
    }
}
