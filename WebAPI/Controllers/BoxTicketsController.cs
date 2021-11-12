using Business.Abstract;
using Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoxTicketsController : ControllerBase
    {
        private readonly IBoxTicketService _boxTicketService;

        public BoxTicketsController(IBoxTicketService boxTicketService)
        {
            _boxTicketService = boxTicketService;
        }

        [HttpPost("add")]
        public IActionResult AddDto(BoxTicketAddDto boxTicketAddDto)
        {
            var result = _boxTicketService.AddDto(boxTicketAddDto);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
