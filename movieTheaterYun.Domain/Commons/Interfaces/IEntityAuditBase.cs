namespace movieTheaterYun.Domain.Commons.Interfaces
{
    public interface IEntityAuditBase : IEntity<Guid>
    {
    }
    public interface IEntityAuditBase<Tkey> : IEntity<Tkey>
    {
    }
}
