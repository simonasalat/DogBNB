using DogBNB.Models;
using System.Collections.Generic;

namespace DogBNB.IServices
{
    public interface IDogService
    {
        public Dog GetDogById(int id);
        public Dog AddDog(Dog dog);
        public void DeleteDog(int dogId);
        public void EditDog(int dogId, Dog newDog);
        public List<Dog> GetDogList(int ownerId);

        public List<Dog> GetAllDogs();
    }
}
