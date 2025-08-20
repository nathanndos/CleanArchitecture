using Domain.Entities.Abstract;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string? Email { get; set; }
        public string? Name { get; set; } 
    }
}
