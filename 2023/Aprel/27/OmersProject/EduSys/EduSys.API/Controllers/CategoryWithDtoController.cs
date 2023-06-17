using Autofac.Core;
using EduSys.API.Filters;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Services;
using EduSys.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace EduSys.API.Controllers
{
	public class CategoryWithDtoController : CustomBaseController
	{
		private readonly IServiceWithDto<Category, CategoryDto> _categoryServiceDto;

        public CategoryWithDtoController(IServiceWithDto<Category, CategoryDto> categoryServiceWithDto)
        {
            _categoryServiceDto = categoryServiceWithDto;
        }

		[HttpGet]
		public async Task<IActionResult> All()
		{
			return CreateActionResult(await _categoryServiceDto.GetAllAsync());
		}

		[ServiceFilter(typeof(NotFoundFilter<Category>))]
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			return CreateActionResult(await _categoryServiceDto.GetByIdAsync(id));
		}

		[HttpPost]
		public async Task<IActionResult> Save(CategoryDto category)
		{
			return CreateActionResult(await _categoryServiceDto.AddAsync(category));
		}

		[HttpPut]
		public async Task<IActionResult> Update(CategoryDto category)
		{
			return CreateActionResult(await _categoryServiceDto.UpdateAsync(category));
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Remove(int id)
		{
			return CreateActionResult(await _categoryServiceDto.RemoveAsync(id));
		}

		[HttpPost("SaveAll")]
		public async Task<IActionResult> Save(List<CategoryDto> categoriesDtos)
		{
			return CreateActionResult(await _categoryServiceDto.AddRangeAsync(categoriesDtos));
		}

		[HttpDelete("RemoveAll")]
		public async Task<IActionResult> RemoveAll(List<int> id)
		{
			return CreateActionResult(await _categoryServiceDto.RemoveRangeAsync(id));
		}

		[HttpGet("Any/{id}")]
		public async Task<IActionResult> Any(int id)
		{
			return CreateActionResult(await _categoryServiceDto.AnyAsync(x => x.Id == id));
		}
	}
}
