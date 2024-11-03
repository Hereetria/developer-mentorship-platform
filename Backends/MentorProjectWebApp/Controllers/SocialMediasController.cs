

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.SocialMediaDtos;
using .Services.SocialMediaServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediasController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetSocialMediaInfo()
        {
            try
            {
                var values = await _socialMediaService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing socialMedia information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocialMediaById(int id)
        {
            try
            {
                var value = await _socialMediaService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"SocialMedia information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving socialMedia information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
            {
            try
            {
                await _socialMediaService.CreateAsync(createSocialMediaDto);
                return Ok("SocialMedia information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating socialMedia information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSocialMedia(int id)
        {
            try
            {
                await _socialMediaService.DeleteAsync(id);
                return Ok("SocialMedia information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting socialMedia information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            try
            {
                await _socialMediaService.UpdateAsync(updateSocialMediaDto);
                return Ok("SocialMedia information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating socialMedia information: " + ex.Message);
            }
        }

    }
}