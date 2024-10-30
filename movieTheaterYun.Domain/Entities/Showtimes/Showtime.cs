using movieTheaterYun.Domain.Commons;
using movieTheaterYun.Domain.Entities.Bookings;
using movieTheaterYun.Domain.Entities.Halls;
using movieTheaterYun.Domain.Entities.Movies;
namespace movieTheaterYun.Domain.Entities.Showtimes
{
    public class Showtime : EntityAuditBase
    {
        public Guid Id { get; set; }
        public DateTimeOffset TimeStartShow { get; set; }
        public DateTimeOffset TimeEndShow { get; set; }
        public DateTimeOffset DateShow { get; set; }

        #region Relationship
        public Guid MovieId { get; set; }
        public virtual Movie Movie {  get; set; } 

        public Guid HallId { get; set; }
        public virtual Hall Hall { get; set; }

        public virtual ICollection<Booking>? bookings { get; set; }
        #endregion
    }
}
