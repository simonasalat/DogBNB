using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB_Db;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DogBNB.Repositories
{
    public class DogRepository : IDogRepository
    {
        private readonly DogBNBDbContext _context;
        public DogRepository(DogBNBDbContext context)
        {
            _context = context;
        }
        public DogRepository()
        {

        }

        public Dog GetDogById(string id)
        {
            var d = _context.Dogs.Where(x => x.DogId == id).First();
           
            _ = Enum.TryParse(d.Size, out DogSize size);
            var dog = new Dog
            {
                OwnerId = d.OwnerId,
                Name = d.Name,
                Breed = d.Breed,
                Age = d.Age,
                Size = size,
                Traits = d.Traits,
            };

            return dog;
        }
        public Dog Add(Dog dog)
        {
            var d = new DogBNB_Db.Entities.Dog
            {
                OwnerId = dog.OwnerId,
                Name = dog.Name,
                Breed = dog.Breed,
                Age = dog.Age,
                Size = dog.Size.ToString(),
                Traits = dog.Traits
            };

            _context.Dogs.Add(d);
            _context.SaveChanges();

            return dog;
        }
        public void DeleteDog(string dogId)
        {
            var dog = _context.Dogs.Where(x => x.DogId == dogId).First();
            _context.Dogs.Remove(dog);
            _context.SaveChanges();
        }
        public void EditDog(string dogId, Dog newDog)
        {
            var dog = _context.Dogs.Where(x => x.DogId == dogId).First();
            dog.Name = newDog.Name;
            dog.Breed = newDog.Breed;
            dog.Age = newDog.Age;
            dog.Size = newDog.Size.ToString();
            dog.Traits = newDog.Traits;
            _context.Dogs.Update(dog);
            _context.SaveChanges();
        }
        public List<Dog> GetDogs(string ownerId)
        {
            var list = _context.Dogs.Where(x => x.OwnerId == ownerId).ToList();

            var dogs = new List<Dog>();

            foreach (var item in list)
            {
                _ = Enum.TryParse(item.Size, out DogSize size);
                var dog = new Dog
                {
                    OwnerId = item.OwnerId,
                    Name = item.Name,
                    Breed = item.Breed,
                    Age = item.Age,
                    Size = size,
                    Traits = item.Traits,
                };
                dogs.Add(dog);
            }

            return dogs;
        }

    }
}
