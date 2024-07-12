using EduHome.App.context;
using EduHome.App.Models;
using EduHome.App.Repositories.Interfaces;

namespace EduHome.App.Repositories.Implements
{
    public class SliderRepository:GenericRepository<Slider>, ISliderRepository
    {
        public SliderRepository(EduHomeDbContext context): base(context)
        {
            
        }
    }
}
