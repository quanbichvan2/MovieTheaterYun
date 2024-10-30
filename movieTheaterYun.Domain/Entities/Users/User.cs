using Microsoft.AspNetCore.Identity;
using movieTheaterYun.Domain.Commons;
using movieTheaterYun.Domain.Entities.Bookings;

namespace movieTheaterYun.Domain.Entities.Users
{
    public class User : IdentityUser
    {
        public string? Avatar { get; set; }
        public string FullName { get; set; }
        public string? Address { get; set; }
        public DateTimeOffset? BirthDate { get; set; } // để giảm giá thôi
        #region Relationship
        public Guid BookingId { get; set; }
        public virtual Booking Booking { get; set; }
        #endregion
    }
    public class Role : IdentityRole
    {
        public string RoleName { get; set; }
    }
}
