﻿using EduSys.API.Filters;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduSys.API.Controllers
{
	public class ProductWithDtoController : CustomBaseController
	{
		private readonly IProductServiceWithDto _productServiceWithDto;

        public ProductWithDtoController(IProductServiceWithDto productServiceWithDto)
        {
            _productServiceWithDto = productServiceWithDto;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            return CreateActionResult(await _productServiceWithDto.GetAllAsync());
        }

		[ServiceFilter(typeof(NotFoundFilter<Product>))]
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			return CreateActionResult(await _productServiceWithDto.GetByIdAsync(id));
		}

		[HttpPost]
		public async Task<IActionResult> Save(ProductCreateDto productDto)
		{
			return CreateActionResult(await _productServiceWithDto.AddAsync(productDto));
		}

		[HttpPut]
		public async Task<IActionResult> Update(ProductUpdateDto productDto)
		{
			return CreateActionResult(await _productServiceWithDto.UpdateAsync(productDto));
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Remove(int id)
		{
			return CreateActionResult(await _productServiceWithDto.RemoveAsync(id));
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetProductsWithCategory()
		{
			return CreateActionResult(await _productServiceWithDto.GetProductsWithCategory());
		}

		[HttpPost("SaveAll")]
		public async Task<IActionResult> Save(List<ProductDto> productsDtos)
		{
			return CreateActionResult(await _productServiceWithDto.AddRangeAsync(productsDtos));
		}

		[HttpDelete("RemoveAll")]
		public async Task<IActionResult> RemoveAll(List<int> id)
		{
			return CreateActionResult(await _productServiceWithDto.RemoveRangeAsync(id));
		}

		[HttpGet("Any/{id}")]
		public async Task<IActionResult> Any(int id)
		{
			return CreateActionResult(await _productServiceWithDto.AnyAsync(x => x.Id == id));
		} 
	}
}
