

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.ArticleTagDtos;
using DataAccessLayer.Services.ArticleTagServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleTagsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IArticleTagService _articleTagService;

        public ArticleTagsController(IArticleTagService articleTagService, IMapper mapper)
        {
            _articleTagService = articleTagService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetArticleTagInfo()
        {
            try
            {
                var values = await _articleTagService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing articleTag information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleTagById(int id)
        {
            try
            {
                var value = await _articleTagService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"ArticleTag information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving articleTag information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticleTag(CreateArticleTagDto createArticleTagDto)
            {
            try
            {
                await _articleTagService.CreateAsync(createArticleTagDto);
                return Ok("ArticleTag information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating articleTag information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticleTag(int id)
        {
            try
            {
                await _articleTagService.DeleteAsync(id);
                return Ok("ArticleTag information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting articleTag information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateArticleTag(UpdateArticleTagDto updateArticleTagDto)
        {
            try
            {
                await _articleTagService.UpdateAsync(updateArticleTagDto);
                return Ok("ArticleTag information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating articleTag information: " + ex.Message);
            }
        }

    }
}