using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstarct;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TicketManager>().As<ITicketService>();
            builder.RegisterType<EfTicketDal>().As<ITicketDal>();

            builder.RegisterType<BoxTicketManager>().As<IBoxTicketService>();
            builder.RegisterType<EfBoxTicketDal>().As<IBoxTicketDal>();

        }
    }
}
