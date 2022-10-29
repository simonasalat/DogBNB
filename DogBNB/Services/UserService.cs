using DogBNB.Dto_s;
using DogBNB.Models;
using DogBNB.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services
{
    internal class UserService : IUserService
    {

        // private readonly DogBNBDbContext _context;

        //public UserService(DogBNBDbContext ctx)
        //{
        //    _context = ctx;
        //}
        public User CreateUser(UserDto user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsersByName(string username)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(UserDto user)
        {
            throw new NotImplementedException();
        }



    }
}
