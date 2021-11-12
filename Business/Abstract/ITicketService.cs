using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITicketService
    {
        IDataResult<Ticket> GetIdByName(string name);
        IDataResult<List<Ticket>> GetList();
    }
}
