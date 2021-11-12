using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.Dto;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BoxTicketManager : IBoxTicketService
    {
        private readonly IBoxTicketDal _boxTicketDal;
        private readonly ITicketService _ticketService;

        public BoxTicketManager(IBoxTicketDal boxTicketDal, ITicketService ticketService)
        {
            _boxTicketDal = boxTicketDal;
            _ticketService = ticketService;
        }

        public IResult Add(BoxTicket boxTicket)
        {
            _boxTicketDal.Add(boxTicket);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult AddDto(BoxTicketAddDto boxTicketAddDto)
        {
            try
            {
                _ = writeFileAsync(boxTicketAddDto);
                BoxTicket boxTicket = buildBoxTicketByDto(boxTicketAddDto);
                Add(boxTicket);
                return new SuccessResult(Messages.AddedSuccess);
            }
            catch (System.Exception)
            {
                return new ErrorResult(Messages.AddedFailed);

            }
          
        }

        private BoxTicket buildBoxTicketByDto(BoxTicketAddDto boxTicketAddDto)
        {
            var getTicketId = _ticketService.GetIdByName(boxTicketAddDto.TicketName).Data.Id;
            var boxTicket = new BoxTicket
            {   BoxStateId=boxTicketAddDto.BoxStateId,
                ImgUrl = boxTicketAddDto.ImgUrl,
                TicketId = getTicketId,
                BoxHeight = boxTicketAddDto.BoxHeight,
                CordinateX = boxTicketAddDto.CordinateX,
                BoxWith = boxTicketAddDto.BoxWith,
                CordinateY = boxTicketAddDto.CordinateY,

            };
            return boxTicket;
        }
        private async Task writeFileAsync(BoxTicketAddDto boxTicketAddDto)
        {
         var lastDataId= _boxTicketDal.GetList().Last().Id;
            lastDataId = lastDataId == null ? 1 : lastDataId + 1;
            //sıfır olacağı için +1
            using StreamWriter file = new StreamWriter("annotation.txt", append: true);
            await file.WriteLineAsync("\n"+ lastDataId.ToString() + " "+boxTicketAddDto.TicketName+" "+boxTicketAddDto.BoxWith+" "+boxTicketAddDto.BoxHeight);
        }
    }
}
