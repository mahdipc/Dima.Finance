namespace Dima.Finance.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public string CreatedBy { get; protected set; }
        public DateTime? ModifiedAt { get; protected set; }
        public string ModifiedBy { get; protected set; }
    }
}
