

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.MentorContentDtos;
using DataAccessLayer.Services.MentorContentServices;
using BussinessLayer.Services.MentorContentServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MentorContentsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMentorContentManager _mentorContentService;

        public MentorContentsController(IMentorContentManager mentorContentService, IMapper mapper)
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

        [HttpGet("GetMentorContentWithRelations")]
        public async Task<IActionResult> GetMentorContentWithRelations()
        {
            try
            {
                var values = await _mentorContentService.GetMentorContentWithRelationsAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing Mentor Content with Subsections information: " + ex.Message);
            }
        }

        [HttpGet("GetMentorContentWithRelationsById/{id}")]
        public async Task<IActionResult> GetMentorContentWithRelationsById(int id)
        {
            try
            {
                var values = await _mentorContentService.GetMentorContentWithRelationsByIdAsync(id);
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing Mentor Content information: " + ex.Message);
            }
        }
    }
}