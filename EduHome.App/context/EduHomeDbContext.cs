using EduHome.App.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHome.App.context
{
    public class EduHomeDbContext:DbContext
    {
        public EduHomeDbContext()
        {
        }

        public EduHomeDbContext(DbContextOptions<EduHomeDbContext> options) :base(options)
        {
            
        }
        public DbSet<Slider>Sliders { get; set; }
    }
}
