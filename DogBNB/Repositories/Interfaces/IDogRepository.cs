using DogBNB.Models;
using System.Collections.Generic;

namespace DogBNB.Repositories.Interfaces
{
    public interface IDogRepository
    {
        public Dog GetDogById(int id);
        public Dog Add(Dog dog);
        public void DeleteDog(int dogId);
        public void EditDog(int dogId, Dog newDog);
        public List<Dog> GetDogs(int ownerId);
        public List<Dog> GetAllDogs();
    }
}
