

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.SocialMediaDtos;
using DataAccessLayer.Services.SocialMediaServices;
using BussinessLayer.Services.SocialMediaServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly ISocialMediaManager _socialMediaService;

        public SocialMediasController(ISocialMediaManager socialMediaService, IMapper mapper)
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

        [HttpGet("GetSocialMediaWithRelationsAsync")]
        public async Task<IActionResult> GetSocialMediaWithRelationsAsync()
        {
            try
            {
                var values = await _socialMediaService.GetSocialMediaWithRelationsAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing socialMedia information: " + ex.Message);
            }
        }

        [HttpGet("GetSocialMediaWithRelationsById/{id}")]
        public async Task<IActionResult> GetSocialMediasWithRelationsById(int id)
        {
            try
            {
                var values = await _socialMediaService.GetSocialMediaWithRelationsByIdAsync(id);
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing Social Medias information: " + ex.Message);
            }
        }
    }
}