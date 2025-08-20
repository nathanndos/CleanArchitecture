namespace Domain.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public Guid Ide { get; set; }
        public DateTimeOffset? DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public DateTimeOffset? DateDeleted { get; set; }
    }
}
