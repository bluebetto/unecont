namespace UneCont.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public BaseEntity(Guid id)
        {
            Id = id;
        }

        public BaseEntity() { }
    }
}
