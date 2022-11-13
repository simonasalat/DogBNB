using DogBNB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Repositories.Interfaces
{
    public interface ISitterRepository 
    {
        public List<Sitter> GetSitters();
        public Sitter GetSitterById(int id);  
        public Sitter CreateSitter(Sitter sitter, int userId);
        public Sitter UpdateSitter(Sitter sitter, int id);
        public void DeleteSitter(int id);

    }
}
