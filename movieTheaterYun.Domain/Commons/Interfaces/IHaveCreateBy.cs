namespace movieTheaterYun.Domain.Commons.Interfaces
{
    public interface IHaveCreateBy
    {
        string CreatedByUserId { get; set; }
        string CreatedByName { get; set; }
    }
}
