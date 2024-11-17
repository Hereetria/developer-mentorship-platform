

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.ArticleDtos;
using DataAccessLayer.Services.ArticleServices;
using BussinessLayer.Services.ArticleServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IArticleManager _articleService;

        public ArticlesController(IArticleManager articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetArticleInfo()
        {
            try
            {
                var values = await _articleService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing article information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleById(int id)
        {
            try
            {
                var value = await _articleService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Article information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving article information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticle(CreateArticleDto createArticleDto)
            {
            try
            {
                await _articleService.CreateAsync(createArticleDto);
                return Ok("Article information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating article information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            try
            {
                await _articleService.DeleteAsync(id);
                return Ok("Article information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting article information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateArticle(UpdateArticleDto updateArticleDto)
        {
            try
            {
                await _articleService.UpdateAsync(updateArticleDto);
                return Ok("Article information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating article information: " + ex.Message);
            }
        }

        [HttpGet("GetArticleWithRelations")]
        public async Task<IActionResult> GetArticleWithRelations()
        {
            try
            {
                var values = await _articleService.GetArticleWithRelationsAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing Article information: " + ex.Message);
            }
        }

        [HttpGet("GetArticleWithRelationsById/{id}")]
        public async Task<IActionResult> GetArticleWithRelationsById(int id)
        {
            try
            {
                var values = await _articleService.GetArticleWithRelationsByIdAsync(id);
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing Article information: " + ex.Message);
            }
        }
    }
}