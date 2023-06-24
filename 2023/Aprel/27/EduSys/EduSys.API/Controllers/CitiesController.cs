using EduSys.API.Filters;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduSys.API.Controllers
{
    public class CitiesController : CustomBaseController
    {
        private readonly IServiceWithDto<City, CityDto> _cityService;

        public CitiesController(IServiceWithDto<City, CityDto> cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            return CreateActionResult(await _cityService.GetAllAsync());
        }

        [ServiceFilter(typeof(NotFoundFilter<Country>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _cityService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CityDto city)
        {
            return CreateActionResult(await _cityService.AddAsync(city));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CityDto city)
        {
            return CreateActionResult(await _cityService.UpdateAsync(city));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _cityService.RemoveAsync(id));
        }

        [HttpPost("SaveAll")]
        public async Task<IActionResult> Save(List<CityDto> citiesDtos)
        {
            return CreateActionResult(await _cityService.AddRangeAsync(citiesDtos));
        }

        [HttpDelete("RemoveAll")]
        public async Task<IActionResult> RemoveAll(List<int> id)
        {
            return CreateActionResult(await _cityService.RemoveRangeAsync(id));
        }

        [HttpGet("Any/{id}")]
        public async Task<IActionResult> Any(int id)
        {
            return CreateActionResult(await _cityService.AnyAsync(x => x.Id == id));
        }
    }
}
