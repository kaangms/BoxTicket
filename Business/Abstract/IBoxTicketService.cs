using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;

namespace Business.Abstract
{
    public interface IBoxTicketService
    {
        IResult Add(BoxTicket boxTicket);
        IResult AddDto(BoxTicketAddDto boxTicketAddDto);
    }
}
