using movieTheaterYun.Domain.Commons;
using movieTheaterYun.Domain.Entities.Discounts;
using movieTheaterYun.Domain.Entities.Halls;
using movieTheaterYun.Domain.Entities.Showtimes;
using movieTheaterYun.Domain.Entities.Snacks;
using movieTheaterYun.Domain.Entities.Tickets;
using movieTheaterYun.Domain.Entities.Users;

namespace movieTheaterYun.Domain.Entities.Bookings
{
    public class Booking : EntityAuditBase
    {
        public DateTimeOffset CreateTime_Date{ get; set; }
        public decimal BookingFee {  get; set; }

        #region Relationship
        public Guid? ShowtimeId { get; set; }
        public Showtime? showtime { get; set; }
        public virtual ICollection<Seat>? Seats { get; set; }
        public Guid? DiscountId { get; set; }
        public virtual Discount? Discount{ get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }
        public virtual ICollection<SnackBooking>? SnackBookings { get; set; }
        public virtual ICollection<User>? Users { get; set; }

        #endregion
    }
    // lý do không gộp snack, discount và ticket vào bảng Booking là vì mong muốn khả năng mở rộng cho 3 bản về sau. Không muốn phải phụ thuộc vào booking
    // việc tách bảng sẽ giúp cải thiện hiệu năng khi chỉ cần truy vấn các bảng snack, discount, ticket mà không cần query vào booking
    // bảng snack là vì muốn sau này update thêm combo
    // bảng discount là vì muốn sau này giảm giá đa dạng hơn từ snack, vé, combo
    // bảng ticket là vì muốn hiển thị thông tin chi tiết giá vé cho người dùng và thêm đa dạng các loại vé mới
    // nghiên cứu từ Designing Domain Model cụ thể DDD (Domain Driven Design) : tham khảo phần cách tổ chức và quản lý các domain entity.
    // Bounded Context trong Domain-Driven Design.
    // Bounded Context là thuật ngữ từ Domain-Driven Design (DDD), dùng để chỉ một phần phân tách của một hệ thống lớn hơn, trong đó các mô hình kinh doanh riêng lẻ và các hiện vật phần mềm liên quan của chúng có thể phát triển độc lập.
}
