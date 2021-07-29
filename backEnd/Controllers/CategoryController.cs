using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;
using backEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace backEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public List<Category> List()
        {
            return _categoryService.GetCategories();
        }
        [HttpGet("{id}")]
        public Category GetById(int id)
        {
            return _categoryService.GetCategoryById(id);
        }
        [HttpPost]
        public IActionResult Create(CategoryDTO category)
        {
            if (_categoryService.CreateCategory(category))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public IActionResult Update(CategoryDTO category, int id)
        {
            if (_categoryService.UpdateCategory(category, id))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_categoryService.DeleteCategory(id))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}