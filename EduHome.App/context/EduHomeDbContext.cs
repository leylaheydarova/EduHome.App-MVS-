using Microsoft.EntityFrameworkCore;

namespace EduHome.App.context
{
    public class EduHomeDbContext:DbContext
    {
        public EduHomeDbContext(DbContextOptions<EduHomeDbContext> options) :base(options)
        {
            
        }
    }
}
