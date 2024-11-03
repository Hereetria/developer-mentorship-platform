

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.ArticleCommentDtos;
using DataAccessLayer.Services.ArticleCommentServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleCommentsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IArticleCommentService _articleCommentService;

        public ArticleCommentsController(IArticleCommentService articleCommentService, IMapper mapper)
        {
            _articleCommentService = articleCommentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetArticleCommentInfo()
        {
            try
            {
                var values = await _articleCommentService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing articleComment information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleCommentById(int id)
        {
            try
            {
                var value = await _articleCommentService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"ArticleComment information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving articleComment information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticleComment(CreateArticleCommentDto createArticleCommentDto)
            {
            try
            {
                await _articleCommentService.CreateAsync(createArticleCommentDto);
                return Ok("ArticleComment information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating articleComment information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticleComment(int id)
        {
            try
            {
                await _articleCommentService.DeleteAsync(id);
                return Ok("ArticleComment information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting articleComment information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateArticleComment(UpdateArticleCommentDto updateArticleCommentDto)
        {
            try
            {
                await _articleCommentService.UpdateAsync(updateArticleCommentDto);
                return Ok("ArticleComment information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating articleComment information: " + ex.Message);
            }
        }

    }
}