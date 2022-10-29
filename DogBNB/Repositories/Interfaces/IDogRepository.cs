using DogBNB.Models;

namespace DogBNB.Repositories.Interfaces
{
    public interface IDogRepository
    {
        public Dog GetDogById(string id);
        public Dog Add(Dog dog);
        public void DeleteDog(string dogId);
        public void EditDog(string dogId, Dog newDog);
        public List<Dog> GetDogs(string ownerId);
    }
}
