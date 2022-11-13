using DogBNB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
        public User GetUserById(int id);
        public List<User> GetUsersByName(string username);
        public User CreateUser(User user);
        public User UpdateUser(User user, int id);
        public void DeleteUser(int id);
    }
}
