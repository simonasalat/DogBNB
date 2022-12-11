using DogBNB.Models;
using DogBNB.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DogBNB_API.Controllers
{
    [Route("api/callendar")]
    [ApiController]
    public class CallendarController : Controller
    {
        private readonly ICallendarService _callendarService;

        public CallendarController(ICallendarService callendarService)
        {
            _callendarService = callendarService;
        }
        [HttpPost]
        public Callendar AddBookedDate([FromBody]Callendar callendar)
        {
            return _callendarService.AddBookedDate(callendar);
        }
        [HttpGet("{id}")]
        public List<Callendar> GetBookedDates(int id)
        {
            return _callendarService.GetBookedDates(id);
        }
        [HttpGet("sitter-by-date/{startDate}/{endDate}")]
        public List<Sitter> GetSitterByDate(DateTime startDate, DateTime endDate)
        {
            return _callendarService.GetSitterByDate(startDate, endDate);
        }
        [HttpDelete("delete/id")]
        public void RemoveBookedDate(int id)
        {
            _callendarService.RemoveBookedDate(id);
        }

    }
}
