using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services
{
    public class UserService : IUserService
    {

         private readonly IUserRepository _repository;

        public UserService(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public User CreateUser(User user)
        {
            return _repository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            _repository.DeleteUser(id);
        }

        public User GetUserById(int id)
        {
          return _repository.GetUserById(id);
        }

        public List<User> GetUsers()
        {
            return _repository.GetUsers();
        }

        public List<User> GetUsersByName(string username)
        {
            return _repository.GetUsersByName(username);
        }

        public User UpdateUser(User user, int id)
        {
            return _repository.UpdateUser(user, id);
        }



    }
}
