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
    internal class SitterService : ISitterService

    {
        private readonly ISitterRepository _repository;

        public SitterService(ISitterRepository sitterRepository)
        {
            _repository = sitterRepository;
        }

        public Sitter CreateSitter(Sitter sitter, int userId)
        {
            return _repository.CreateSitter(sitter, userId);
        }

        public void DeleteSitter(int id)
        {
            _repository.DeleteSitter(id);
        }

        public Sitter GetSitterById(int id)
        {
           return _repository.GetSitterById(id);
        }

        public List<Sitter> GetSitters()
        {
            return _repository.GetSitters();
        }

        public Sitter UpdateSitter(Sitter sitter, int id)
        {
            return _repository.UpdateSitter(sitter, id);
        }
    }
}
