using Autofac.Core;
using AutoMapper;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Services;
using EduSys.Service.Services;
using EduSys.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EduSys.Web.Controllers
{
    public class ProductsController : Controller
    {
        //private readonly IProductService _service;
        
        //private readonly ICategoryService _categoryService;

        //private readonly IMapper _mapper;

        //public ProductsController(IProductService service, ICategoryService categoryService, IMapper mapper)
        //{
        //    _service = service;
        //    _categoryService = categoryService;
        //    _mapper = mapper;
        //}

        private readonly ProductApiService _productApiService;
        private readonly CategoryApiService _categoryApiService;

        public ProductsController(ProductApiService productApiService, CategoryApiService categoryApiService)
        {
            _productApiService = productApiService;
            _categoryApiService = categoryApiService;
        }

        public async Task<IActionResult> Index()
        {
            //return View((await _service.GetProductsWithCategory()).Data);
            return View(await _productApiService.GetProductsWithCategoryAsync());
        }

        public async Task<IActionResult> Save()
        {

            //var categories = await _categoryService.GetAllAsync();

            //var categoriesDto = _mapper.Map<List<CategoryDto>>(categories.ToList());

            //ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");

            //return View();

            var categoriesDto = await _categoryApiService.GetAllAsync();

            ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");

            return View();
        }

		[HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
			//if(ModelState.IsValid)
			//{
			//    await _service.AddAsync(_mapper.Map<Product>(productDto));
			//    return RedirectToAction(nameof(Index));
			//}

			//var categories = await _categoryService.GetAllAsync();

			//var categoriesDto = _mapper.Map<List<CategoryDto>>(categories.ToList());

			//ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");

			//return View(); 

			if (ModelState.IsValid)
			{
				await _productApiService.SaveAsync(productDto);

				return RedirectToAction(nameof(Index));
			}

			var categoriesDto = await _categoryApiService.GetAllAsync();

			ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");

			return View();
		}

		[ServiceFilter(typeof(NotFoundFilter<Product>))]
		public async Task<IActionResult> Update(int id)
        {
			//var product = await _service.GetByIdAsync(id);

			//var categories = await _categoryService.GetAllAsync();

			//var categoriesDto = _mapper.Map<List<CategoryDto>>(categories.ToList());

			//ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");

			//return View(_mapper.Map<ProductDto>(product));

			var product = await _productApiService.GetByIdAsync(id);

			var categoriesDto = await _categoryApiService.GetAllAsync();

			ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");

			return View(product);
		}

        [HttpPost]
        public async Task<IActionResult> Update(ProductDto productDto)
        {
			//if (ModelState.IsValid)
			//{
			//    await _service.UpdateAsync(_mapper.Map<Product>(productDto));
			//    return RedirectToAction(nameof(Index));
			//}

			//var categories = await _categoryService.GetAllAsync();

			//var categoriesDto = _mapper.Map<List<CategoryDto>>(categories.ToList());

			//ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");

			//return View(productDto);

			if (ModelState.IsValid)
			{
				await _productApiService.UpdateAsync(productDto);
				return RedirectToAction(nameof(Index));
			}

			var categoriesDto = await _categoryApiService.GetAllAsync();

			ViewBag.categories = new SelectList(categoriesDto, "Id", "Name", productDto.CategoryId);

			return View(productDto);
		}

        public async Task<IActionResult> Remove(int id)
        {
			//var product = await _service.GetByIdAsync(id);

			//await _service.RemoveAsync(product);

			//return RedirectToAction(nameof(Index));

			await _productApiService.RemoveAsync(id);

			return RedirectToAction(nameof(Index));
		}
    }
}
