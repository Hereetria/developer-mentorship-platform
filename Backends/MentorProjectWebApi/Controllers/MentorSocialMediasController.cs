

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.MentorSocialMediaDtos;
using DataAccessLayer.Services.MentorSocialMediaServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MentorSocialMediasController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMentorSocialMediaService _mentorSocialMediaService;

        public MentorSocialMediasController(IMentorSocialMediaService mentorSocialMediaService, IMapper mapper)
        {
            _mentorSocialMediaService = mentorSocialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMentorSocialMediaInfo()
        {
            try
            {
                var values = await _mentorSocialMediaService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing mentorSocialMedia information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMentorSocialMediaById(int id)
        {
            try
            {
                var value = await _mentorSocialMediaService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"MentorSocialMedia information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving mentorSocialMedia information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateMentorSocialMedia(CreateMentorSocialMediaDto createMentorSocialMediaDto)
            {
            try
            {
                await _mentorSocialMediaService.CreateAsync(createMentorSocialMediaDto);
                return Ok("MentorSocialMedia information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating mentorSocialMedia information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMentorSocialMedia(int id)
        {
            try
            {
                await _mentorSocialMediaService.DeleteAsync(id);
                return Ok("MentorSocialMedia information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting mentorSocialMedia information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMentorSocialMedia(UpdateMentorSocialMediaDto updateMentorSocialMediaDto)
        {
            try
            {
                await _mentorSocialMediaService.UpdateAsync(updateMentorSocialMediaDto);
                return Ok("MentorSocialMedia information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating mentorSocialMedia information: " + ex.Message);
            }
        }

    }
}