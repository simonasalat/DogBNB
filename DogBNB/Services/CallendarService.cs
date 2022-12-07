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
    public class CallendarService : ICallendarService
    {

        private readonly ICallendarRepository _callendarRepository;
        public CallendarService(ICallendarRepository callendarRepository)
        {
            _callendarRepository = callendarRepository;
        }
        public Callendar AddBookedDate(Callendar callendar)
        {
            return _callendarRepository.AddBookedDate(callendar);
        }

        public List<Callendar> GetBookedDates(int id)
        {
            return _callendarRepository.GetBookedDates(id);
        }

        public List<Sitter> GetSitterByDate(DateTime startDate, DateTime endDate)
        {
            return _callendarRepository.GetSitterByDate(startDate, endDate);
        }

        public void RemoveBookedDate(int id)
        {
            _callendarRepository.RemoveBookedDate(id);
        }
    }
}
