namespace EduHome.App.Models.BaseModel
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set;}
        public bool IsDeleted { get; set; } 
    }
}
