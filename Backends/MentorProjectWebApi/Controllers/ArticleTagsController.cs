using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.ArticleTagDtos;
using BussinessLayer.Services.ArticleTagServices;

namespace MentorProjectWebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ArticleTagsController : ControllerBase

    {

        private readonly IArticleTagManager _articleTagService;

        public ArticleTagsController(IArticleTagManager articleTagService)
        {
            _articleTagService = articleTagService;
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

        [HttpGet("GetTagListByArticleId/{articleId}")]
        public async Task<IActionResult> GetTagListByArticleId(int articleId)
        {
            try
            {
                var value = await _articleTagService.GetTagListByArticleIdAsync(articleId);
                if (value == null)
                {
                    return NotFound($"Tag information not found: {articleId}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving Tag information: " + ex.Message);
            }
        }

        [HttpGet("GetArticleDetailListByTagId/{tagId}")]
        public async Task<IActionResult> GetArticleDetailListByTagId(int tagId)
        {
            try
            {
                var value = await _articleTagService.GetArticleDetailListByTagIdAsync(tagId);
                if (value == null)
                {
                    return NotFound($"Tag information not found: {tagId}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving Tag information: " + ex.Message);
            }
        }

        [HttpGet("GetArticleTagWithRelations")]
        public async Task<IActionResult> GetArticleTagWithRelations()
        {
            try
            {
                var value = await _articleTagService.GetArticleTagWithRelationsAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing Tag information: " + ex.Message);
            }
        }

        [HttpGet("GetArticleTagWithRelationsById/{id}")]
        public async Task<IActionResult> GetArticleTagWithRelationsById(int id)
        {
            try
            {
                var value = await _articleTagService.GetArticleTagWithRelationsByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Tag information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving Tag information: " + ex.Message);
            }
        }
    }
}