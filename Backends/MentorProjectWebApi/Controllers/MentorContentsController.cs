

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.MentorContentDtos;
using DataAccessLayer.Services.MentorContentServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MentorContentsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMentorContentService _mentorContentService;

        public MentorContentsController(IMentorContentService mentorContentService, IMapper mapper)
        {
            _mentorContentService = mentorContentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMentorContentInfo()
        {
            try
            {
                var values = await _mentorContentService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing mentorContent information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMentorContentById(int id)
        {
            try
            {
                var value = await _mentorContentService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"MentorContent information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving mentorContent information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateMentorContent(CreateMentorContentDto createMentorContentDto)
            {
            try
            {
                await _mentorContentService.CreateAsync(createMentorContentDto);
                return Ok("MentorContent information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating mentorContent information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMentorContent(int id)
        {
            try
            {
                await _mentorContentService.DeleteAsync(id);
                return Ok("MentorContent information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting mentorContent information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMentorContent(UpdateMentorContentDto updateMentorContentDto)
        {
            try
            {
                await _mentorContentService.UpdateAsync(updateMentorContentDto);
                return Ok("MentorContent information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating mentorContent information: " + ex.Message);
            }
        }

    }
}