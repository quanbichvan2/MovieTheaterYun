using movieTheaterYun.Domain.Commons;
using movieTheaterYun.Domain.Entities.Bookings;

namespace movieTheaterYun.Domain.Entities.Tickets
{
    public class TicketType : EntityAuditBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; } 
        public string? Description { get; set; }

        #region Relationship
        public virtual ICollection<Ticket>? Tickets { get; set; }
        #endregion
    }
    public class Ticket : EntityAuditBase
    {
        public int Quantity { get; set; } = 1; // thiết lập default là 1
        #region Relationship
        public Guid TicketTypeId { get; set; }
        public TicketType TicketType { get; set; }

        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }
        #endregion
    }
}
