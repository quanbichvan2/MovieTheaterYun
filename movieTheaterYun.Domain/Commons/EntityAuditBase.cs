using movieTheaterYun.Domain.Commons.Interfaces;

namespace movieTheaterYun.Domain.Commons
{
    // việc sử dụng gọi IHaveCreateAt, IHaveCreateBy, IHaveUpdatedAt, IHaveUpdatedBy, ISoftDelete mục đích:
    // tăng tính linh hoạt và khả năng mở rộng, ta có thể sử dụng lại các thuộc tính đó mà không cần phải kế thừa toàn bộ lớp EntityAuditBase
    // giúp giảm sự phụ thuộc và tái sử dụng
    // tăng tính nhất quán và rõ ràng
    public abstract class EntityAuditBase : EntityBase, IEntityAuditBase, IHaveCreateAt, IHaveCreateBy, IHaveUpdatedAt, IHaveUpdatedBy, ISoftDelete
    {
        public DateTimeOffset CreatedAt { get; set; }
        public string CreatedByUserId { get; set; }
        public string CreatedByName { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string UpdatedByUserId { get; set; }
        public string UpdatedByName { get; set; }
        public bool IsDeleted { get; set; }
    }
    public abstract class EntityAuditBase<TKey> : EntityBase<TKey>, IEntityAuditBase<TKey>, IHaveCreateAt, IHaveCreateBy, IHaveUpdatedAt, IHaveUpdatedBy, ISoftDelete
    {
        public DateTimeOffset CreatedAt { get; set; }
        public string CreatedByUserId { get; set; }
        public string CreatedByName { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string UpdatedByUserId { get; set; }
        public string UpdatedByName { get; set; }
        public bool IsDeleted { get; set; }
    }

}
