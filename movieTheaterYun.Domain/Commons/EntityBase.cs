using movieTheaterYun.Domain.Commons.Interfaces;

namespace movieTheaterYun.Domain.Commons
{
    public abstract class EntityBase : IEntityBase
    {
        public Guid Id { get; set; }
    }
    public abstract class EntityBase<Tkey> : IEntityBase<Tkey>
    {
        public Tkey Id { get; set; }
    }
}
