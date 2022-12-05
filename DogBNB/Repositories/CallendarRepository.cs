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
    public class CallendarRepository : ICallendarRepository
    {
        private readonly DogBNBDbContext _context;
        public CallendarRepository(DogBNBDbContext context)
        {
            _context = context;
        }
        public CallendarRepository()
        {

        }
        public Callendar AddBookedDate(Callendar callendar)
        {
            var c = new DogBNB_Db.Entities.Callendar
            {
                UserId = callendar.UserId,
                BookedDayStart = callendar.BookedDayStart,      
                BookedDayEnd = callendar.BookedDayEnd
            };

            _context.Callendars.Add(c);
            _context.SaveChanges();

            return callendar;
        }

        public List<Callendar> GetBookedDates(int id)
        {
           List < Callendar > callendar=new List<Callendar >();
           var list = _context.Callendars.Where(c => c.UserId == id).ToList();
            foreach (var item in list)
            {
                var c =new Callendar
                {
                    UserId = item.UserId,
                    BookedDayStart = item.BookedDayStart,
                    BookedDayEnd = item.BookedDayEnd

                };
                callendar.Add(c);
            }
            return callendar;

        }

        public List<Sitter> GetSitterByDate(DateTime startDate, DateTime endDate)
        {
            var list = _context.Sitters.Where(s=> _context.Callendars.All(c =>c.UserId==s.SitterId && c.BookedDayEnd>endDate && c.BookedDayStart<startDate)).ToList();
            List<Sitter> sitters = new List<Sitter>();

            foreach(var item in list)
            {
                var s = new Sitter
                {
                    Id = item.UserId,
                    Description = item.Description

                };
            }
            return sitters;
        }

        public void RemoveBookedDate(int id)
        {
            var bd= _context.Callendars.Where(c => c.UserId == id).FirstOrDefault();
            _context.Callendars.Remove(bd);
            _context.SaveChanges();
        }
    }
}
