using EduHome.App.Models;
using EduHome.App.Repositories.Implements;
using EduHome.App.Repositories.Interfaces;
using EduHome.App.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace EduHome.App.Services.Implements
{
    public class SliderService : ISliderService

    {
        private readonly ISliderRepository _repository;
        public SliderService(ISliderRepository repository)
        {
            _repository = repository;
        }
        public Task AddAsync(Slider slider)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Slider>> GetAllAsync()
        {
            return await (await _repository.GetAllAsync(x => !x.IsDeleted)).ToListAsync();
        }

        public async Task<Slider> GetAsync(string id)
        {
            Slider slider = await _repository.GetAsync(x => x.Id.ToString() == id && !x.IsDeleted);
            if(slider == null)
            {
                throw new NullReferenceException();
            }
            return slider;
        }

        public async Task RemoveAsync(string id)
        {
            Slider slider = await GetAsync(id);
            slider.IsDeleted = true;
            await _repository.SaveAsync();
        }

        public Task UpdateAsync(Slider slider)
        {
            throw new NotImplementedException();
        }
    }
}
