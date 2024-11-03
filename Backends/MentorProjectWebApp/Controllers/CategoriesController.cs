

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.CategoryDtos;
using .Services.CategoryServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryInfo()
        {
            try
            {
                var values = await _categoryService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing category information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            try
            {
                var value = await _categoryService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Category information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving category information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
            {
            try
            {
                await _categoryService.CreateAsync(createCategoryDto);
                return Ok("Category information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating category information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                await _categoryService.DeleteAsync(id);
                return Ok("Category information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting category information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            try
            {
                await _categoryService.UpdateAsync(updateCategoryDto);
                return Ok("Category information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating category information: " + ex.Message);
            }
        }

    }
}