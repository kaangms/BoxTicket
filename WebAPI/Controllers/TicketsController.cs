using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _ticketService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest("hata");
        }
    }
}
