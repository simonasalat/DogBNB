using DogBNB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services.Interfaces
{
    public interface ICallendarService
    {
        public List<Callendar> GetBookedDates(int id);
        public Callendar AddBookedDate(Callendar callendar);
        public List<Sitter> GetSitterByDate(DateTime startDate, DateTime endDate);
        public void RemoveBookedDate(int id);
    }
}
