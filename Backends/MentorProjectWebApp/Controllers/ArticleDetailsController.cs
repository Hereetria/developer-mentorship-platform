

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.ArticleDetailDtos;
using .Services.ArticleDetailServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleDetailsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IArticleDetailService _articleDetailService;

        public ArticleDetailsController(IArticleDetailService articleDetailService, IMapper mapper)
        {
            _articleDetailService = articleDetailService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetArticleDetailInfo()
        {
            try
            {
                var values = await _articleDetailService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing articleDetail information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleDetailById(int id)
        {
            try
            {
                var value = await _articleDetailService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"ArticleDetail information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving articleDetail information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticleDetail(CreateArticleDetailDto createArticleDetailDto)
            {
            try
            {
                await _articleDetailService.CreateAsync(createArticleDetailDto);
                return Ok("ArticleDetail information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating articleDetail information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticleDetail(int id)
        {
            try
            {
                await _articleDetailService.DeleteAsync(id);
                return Ok("ArticleDetail information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting articleDetail information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateArticleDetail(UpdateArticleDetailDto updateArticleDetailDto)
        {
            try
            {
                await _articleDetailService.UpdateAsync(updateArticleDetailDto);
                return Ok("ArticleDetail information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating articleDetail information: " + ex.Message);
            }
        }

    }
}