using movieTheaterYun.Domain.Commons;
using movieTheaterYun.Domain.Entities.Bookings;
using movieTheaterYun.Domain.Entities.Showtimes;

namespace movieTheaterYun.Domain.Entities.Halls
{
    public class Hall :EntityAuditBase
    {
        public string Name { get; set; }

        #region Relationship
        public virtual ICollection<Showtime>? showtimes { get; set; }

        public Guid HallId { get; set; }
        public virtual HallType hallType { get; set; }

        public virtual ICollection<Seat> seat { get; set; }
        #endregion
    }
    public class HallType : EntityAuditBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Seat : EntityAuditBase
    {
        public string Name { get; set; }
        public string SeatLocation { get; set; }

        #region Relationship
        public virtual ICollection<Booking> Bookings { get; set; }

        public Guid HallId { get; set; }
        public virtual Hall Hall { get; set; }

        public Guid SeatTypeId { get; set; }
        public virtual SeatType SeatType { get; set; }
        #endregion
    }
    public class SeatType : EntityAuditBase
    {
        public string Name { get; set; }

        #region Relationship
        public virtual ICollection<Seat>? Seats { get; set; }
        #endregion
    }
}
