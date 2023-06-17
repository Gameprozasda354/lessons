using EduSys.API.Filters;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace EduSys.API.Controllers
{
    public class CountriesController : CustomBaseController
    {
        private readonly IServiceWithDto<Country, CountryDto> _countryServiceDto;

        public CountriesController(IServiceWithDto<Country, CountryDto> countryServiceDto)
        {
            _countryServiceDto = countryServiceDto;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            return CreateActionResult(await _countryServiceDto.GetAllAsync());
        }

        [ServiceFilter(typeof(NotFoundFilter<Country>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _countryServiceDto.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CountryDto country)
        {
            return CreateActionResult(await _countryServiceDto.AddAsync(country));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CountryDto country)
        {
            return CreateActionResult(await _countryServiceDto.UpdateAsync(country));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _countryServiceDto.RemoveAsync(id));
        }

        [HttpPost("SaveAll")]
        public async Task<IActionResult> Save(List<CountryDto> countriesDtos)
        {
            return CreateActionResult(await _countryServiceDto.AddRangeAsync(countriesDtos));
        }

        [HttpDelete("RemoveAll")]
        public async Task<IActionResult> RemoveAll(List<int> id)
        {
            return CreateActionResult(await _countryServiceDto.RemoveRangeAsync(id));
        }

        [HttpGet("Any/{id}")]
        public async Task<IActionResult> Any(int id)
        {
            return CreateActionResult(await _countryServiceDto.AnyAsync(x => x.Id == id));
        }
    }
}
