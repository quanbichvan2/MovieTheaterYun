using movieTheaterYun.Domain.Commons;
using movieTheaterYun.Domain.Entities.Bookings;

namespace movieTheaterYun.Domain.Entities.Discounts
{
    public class Discount :EntityAuditBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        #region Relationship
        public Guid DiscountTypeId { get; set; }
        public virtual DiscountType DiscountType { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }

        #endregion
    }
    public class DiscountType : EntityAuditBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        #region Relationship
        public virtual ICollection<Discount>? Discounts { get; set; }
        #endregion

    }
}
