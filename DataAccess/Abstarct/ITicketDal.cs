using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstarct
{
    public interface ITicketDal : IEntityRepository<Ticket>
    {
    }
}
