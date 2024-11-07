

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.MentorSkillDtos;
using DataAccessLayer.Services.MentorSkillServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MentorSkillsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMentorSkillService _mentorSkillService;

        public MentorSkillsController(IMentorSkillService mentorSkillService, IMapper mapper)
        {
            _mentorSkillService = mentorSkillService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMentorSkillInfo()
        {
            try
            {
                var values = await _mentorSkillService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing mentorSkill information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateMentorSkill(CreateMentorSkillDto createMentorSkillDto)
            {
            try
            {
                await _mentorSkillService.CreateAsync(createMentorSkillDto);
                return Ok("MentorSkill information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating mentorSkill information: " + ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMentorSkill(DeleteMentorSkillDto deleteDto)
        {
            try
            {
                if (deleteDto == null)
                {
                    return BadRequest("DeleteMentorSkillDto cannot be null.");
                }

                await _mentorSkillService.DeleteMentorSkill(deleteDto);
                return Ok("MentorSkill information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting mentorSkill information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMentorSkill(UpdateMentorSkillDto updateMentorSkillDto)
        {
            try
            {
                await _mentorSkillService.UpdateAsync(updateMentorSkillDto);
                return Ok("MentorSkill information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating mentorSkill information: " + ex.Message);
            }
        }

        [HttpGet("GetMentorListBySkillIdAsync/{id}")]
        public async Task<IActionResult> GetMentorListBySkillIdAsync(int skillId)
        {
            try
            {
                var value = await _mentorSkillService.GetMentorListBySkillIdAsync(skillId);
                if (value == null)
                {
                    return NotFound($"MentorSkill information not found: {skillId}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving mentorSkill information: " + ex.Message);
            }
        }

        [HttpGet("GetSkillListByMentorIdAsync/{id}")]
        public async Task<IActionResult> GetSkillListByMentorIdAsync(int mentorId)
        {
            try
            {
                var value = await _mentorSkillService.GetSkillListByMentorIdAsync(mentorId);
                if (value == null)
                {
                    return NotFound($"MentorSkill information not found: {mentorId}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving mentorSkill information: " + ex.Message);
            }
        }
    }
}