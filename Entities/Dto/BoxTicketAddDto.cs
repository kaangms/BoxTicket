using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Dto
{
    public class BoxTicketAddDto : IDto
    {
        [Required]
        public int Id { get; set; }
        public string BoxStateId { get; set; }
        public string ImgUrl { get; set; }
        public string TicketName { get; set; }
        public string CordinateX { get; set; }
        public string CordinateY { get; set; }
        public string BoxWith { get; set; }
        public string BoxHeight { get; set; }
    }
}
