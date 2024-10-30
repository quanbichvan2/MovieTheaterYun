namespace movieTheaterYun.Domain.Commons.Interfaces
{
    public interface IEntityBase :IEntity <Guid>
    {

    }
    public interface IEntityBase<Tkey> : IEntity<Tkey>
    {
    }
}
