

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.MentorSkillDtos;
using DataAccessLayer.Services.MentorSkillServices;
using BussinessLayer.Services.MentorSkillServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MentorSkillsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMentorSkillManager _mentorSkillService;

        public MentorSkillsController(IMentorSkillManager mentorSkillService, IMapper mapper)
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMentorSkill(int id)
        {
            try
            {
                await _mentorSkillService.DeleteAsync(id);
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

        [HttpGet("GetMentorListBySkillId/{skillId}")]
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

        [HttpGet("GetSkillListByMentorId/{mentorId}")]
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

        [HttpGet("GetMentorSkillWithRelations")]
        public async Task<IActionResult> GetMentorSkillWithRelations()
        {
            try
            {
                var value = await _mentorSkillService.GetMentorSkillWithRelationsAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing Mentor Skill information: " + ex.Message);
            }
        }

        [HttpGet("GetMentorSkillWithRelationsById/{id}")]
        public async Task<IActionResult> GetMentorSkillWithRelationsById(int id)
        {
            try
            {
                var value = await _mentorSkillService.GetMentorSkillWithRelationsByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Mentor Skill information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving Mentor Skill information: " + ex.Message);
            }
        }

        [HttpGet("GetMentorSkillWithRelationsByMentorId/{mentorId}")]
        public async Task<IActionResult> GetMentorSkillWithRelationsByMentorId(int mentorId)
        {
            try
            {
                var value = await _mentorSkillService.GetMentorSkillWithRelationsByMentorIdAsync(mentorId);
                if (value == null)
                {
                    return NotFound($"Mentor Skill information not found: {mentorId}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving Mentor Skill information: " + ex.Message);
            }
        }
    }
}