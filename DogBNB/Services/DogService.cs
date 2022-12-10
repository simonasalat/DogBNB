using DogBNB.IServices;
using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using System.Collections.Generic;

namespace DogBNB.Services
{
    public class DogService : IDogService
    {
        private readonly IDogRepository _dogRepository;
        public DogService(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }
        public Dog GetDogById(string id) => _dogRepository.GetDogById(id);
        public Dog AddDog(Dog dog) => _dogRepository.Add(dog);
        public void DeleteDog(string id) => _dogRepository.DeleteDog(id);
        public void EditDog(string id, Dog newDog) => _dogRepository.EditDog(id, newDog);
        public List<Dog> GetDogList(string ownerId) => _dogRepository.GetDogs(ownerId);

        public List<Dog> GetAllDogs()
        {
            return _dogRepository.GetAllDogs();
        }
    }
}
