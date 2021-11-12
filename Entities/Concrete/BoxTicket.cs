using Core.Entities;

namespace Entities.Concrete
{
    public class BoxTicket : IEntity
    {
        public int Id { get; set; }
        public string BoxStateId { get; set; }
        public string ImgUrl { get; set; }
        public int TicketId { get; set; }
        public string CordinateX { get; set; }
        public string CordinateY { get; set; }
        public string BoxWith { get; set; }
        public string BoxHeight { get; set; }
    }
}
