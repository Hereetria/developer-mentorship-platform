

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.TagDtos;
using .Services.TagServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly ITagService _tagService;

        public TagsController(ITagService tagService, IMapper mapper)
        {
            _tagService = tagService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTagInfo()
        {
            try
            {
                var values = await _tagService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing tag information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagById(int id)
        {
            try
            {
                var value = await _tagService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Tag information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving tag information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagDto createTagDto)
            {
            try
            {
                await _tagService.CreateAsync(createTagDto);
                return Ok("Tag information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating tag information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTag(int id)
        {
            try
            {
                await _tagService.DeleteAsync(id);
                return Ok("Tag information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting tag information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagDto updateTagDto)
        {
            try
            {
                await _tagService.UpdateAsync(updateTagDto);
                return Ok("Tag information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating tag information: " + ex.Message);
            }
        }

    }
}