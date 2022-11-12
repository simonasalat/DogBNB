﻿using DogBNB.Models;
namespace DogBNB.IServices
{
    public interface IDogService
    {
        public Dog GetDogById(string id);
        public Dog AddDog(Dog dog);
        public void DeleteDog(string dogId);
        public void EditDog(string dogId, Dog newDog);
        public List<Dog> GetDogList(string ownerId);
    }
}
