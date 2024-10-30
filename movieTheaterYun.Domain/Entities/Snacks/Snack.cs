using movieTheaterYun.Domain.Commons;
using movieTheaterYun.Domain.Entities.Bookings;

namespace movieTheaterYun.Domain.Entities.Snacks
{
    public class Snack :EntityAuditBase
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        // mô tả cho phần combo, tạm thời gộp combo như 1 product
        // chẳng hạn type có 3 kiểu: bắp, nước, combo thì bên snack nếu kiểu combo thì name nó sẽ ghi Happy20/11 và description sẽ mô tả thông tin các sản phẩm trong snack này
        #region Relationship
        public Guid SnackTypeId { get; set; }
        public virtual SnackType SnackType { get; set; }
        public virtual ICollection<SnackBooking>? SnackBookings { get; set; }
        #endregion
    }
    public class SnackType : EntityAuditBase 
    {
        public string Name { get; set; }

        #region Relationship
        public virtual ICollection<Snack>? Snacks { get; set; }
        #endregion
    }
    public class SnackBooking : EntityAuditBase
    {
        public int Quantity { get; set; }

        #region Relationship
        public Guid SnackId { get; set; }
        public virtual Snack Snack{ get; set; }
        public Guid BookingId { get; set; }
        public virtual Booking Booking { get; set; }
        #endregion
    }
}
