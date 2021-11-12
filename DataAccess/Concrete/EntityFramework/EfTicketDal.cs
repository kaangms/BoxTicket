using Core.DataAccess.EntityFramwork;
using DataAccess.Abstarct;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTicketDal : EfEntityRepositoryBase<Ticket, BoxTicketDbContext>, ITicketDal
    {
    }
}
