using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class TicketManager : ITicketService
    {
        private readonly ITicketDal _ticetDal;

        public TicketManager(ITicketDal ticetDal)
        {
            _ticetDal = ticetDal;
        }

        public IDataResult<Ticket> GetIdByName(string name)
        {
            var result = _ticetDal.Get(t => t.TicketName == name);
            return new SuccessDataResult<Ticket>(result);
        }

        public IDataResult<List<Ticket>> GetList()
        {
            var result = _ticetDal.GetList().ToList();
            return new SuccessDataResult<List<Ticket>>(result);
        }
    }
}
