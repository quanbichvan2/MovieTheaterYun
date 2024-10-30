namespace movieTheaterYun.Domain.Commons.Interfaces
{
    //    Tuân Thủ Nguyên Tắc SOLID
    //    Nguyên tắc Interface Segregation Principle trong SOLID khuyến khích việc sử dụng nhiều interface nhỏ hơn là một interface lớn.
    //    Điều này giúp cho các entity không cần phải phụ thuộc vào các phương thức không cần thiết.
    public interface IEntity 
    {
    }
    public interface IEntity<Tkey> : IEntity
    {   
        Tkey Id { get; set; }
    }
}
