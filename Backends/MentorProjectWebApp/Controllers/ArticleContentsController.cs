

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.ArticleContentDtos;
using .Services.ArticleContentServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleContentsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IArticleContentService _articleContentService;

        public ArticleContentsController(IArticleContentService articleContentService, IMapper mapper)
        {
            _articleContentService = articleContentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetArticleContentInfo()
        {
            try
            {
                var values = await _articleContentService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing articleContent information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleContentById(int id)
        {
            try
            {
                var value = await _articleContentService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"ArticleContent information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving articleContent information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticleContent(CreateArticleContentDto createArticleContentDto)
            {
            try
            {
                await _articleContentService.CreateAsync(createArticleContentDto);
                return Ok("ArticleContent information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating articleContent information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticleContent(int id)
        {
            try
            {
                await _articleContentService.DeleteAsync(id);
                return Ok("ArticleContent information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting articleContent information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateArticleContent(UpdateArticleContentDto updateArticleContentDto)
        {
            try
            {
                await _articleContentService.UpdateAsync(updateArticleContentDto);
                return Ok("ArticleContent information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating articleContent information: " + ex.Message);
            }
        }

    }
}