

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

        private readonly IArticleTagService _articleTagService;

        public ArticleTagsController(IArticleTagService articleTagService)
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

        [HttpDelete]
        public async Task<IActionResult> DeleteArticleTag(DeleteArticleTagDto deleteDto)
        {
            try
            {
                if (deleteDto == null)
                {
                    return BadRequest("DeleteArticleTagDto cannot be null.");
                }

                await _articleTagService.DeleteArticleTag(deleteDto);
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

        [HttpGet("GetTagListByArticleId/{id}")]
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

        [HttpGet("GetArticleDetailListByTagId/{id}")]
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
    }
}