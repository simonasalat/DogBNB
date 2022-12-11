using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB_Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Repositories
{
    public class SitterRepository : ISitterRepository
    {

        private readonly DogBNBDbContext _context;
        private readonly IUserRepository _userRepository;
        public SitterRepository(DogBNBDbContext context, IUserRepository userReppsitory)
        {
            _context = context;
            _userRepository = userReppsitory;
        }
        public SitterRepository()
        {
           
        }

        public Sitter CreateSitter(Sitter sitter, int id)
        {
            var s = new DogBNB_Db.Entities.Sitter
            {
                UserId = id,
                Description = sitter.Description

            };

            _context.Sitters.Add(s);
            _context.SaveChanges();

            return sitter;
        }

        public void DeleteSitter(int id)
        {
            var sitter = _context.Sitters.Where(s => s.UserId == id).First();
            _context.Sitters.Remove(sitter);
            _context.SaveChanges();
        }

        public Sitter GetSitterById(int id)
        {
            var s = _context.Sitters.Where(s => s.UserId == id).First();
            var u = _context.Users.Where(u => u.UserId == id).First();
            _ = Enum.TryParse(u.Gender, out GenderType gender);
            var sitter = new Sitter
            {
                Name= u.Name,
                Surname= u.Surname,
                Email= u.Email,
                Phone= u.Phone,
                Gender=gender,
                Description=s.Description

            };
            return sitter;
        }

        public List<Sitter> GetSitters()
        {
            var sitters = _context.Sitters.ToList();
            var sitterList = new List<Sitter>();
            foreach (var s in sitters)
            {
                var u = _userRepository.GetUserById(s.UserId);
                var sitter = new Sitter
                {
                    Name = u.Name,
                    Surname = u.Surname,
                    Email = u.Email,
                    Phone = u.Phone,
                    Gender = u.Gender,
                    Description =s.Description
                };
                sitterList.Add(sitter);
            }
            return sitterList;

        }

        public Sitter UpdateSitter(Sitter sitter, int id)//TODO: create SitterDTO?
        {
            var s = _context.Sitters.Where(s => s.UserId == id).First();
            if (s != null)
            {
                s.Description = s.Description;
            }

            return sitter;
        }
    }
}
