using EduHome.App.Models.BaseModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.App.Models
{
    public class Slider:BaseEntity
    {
        public string? ImageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile? file { get; set; }
    }
}
