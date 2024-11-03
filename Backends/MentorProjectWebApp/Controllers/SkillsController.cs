

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.SkillDtos;
using .Services.SkillServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly ISkillService _skillService;

        public SkillsController(ISkillService skillService, IMapper mapper)
        {
            _skillService = skillService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetSkillInfo()
        {
            try
            {
                var values = await _skillService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing skill information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSkillById(int id)
        {
            try
            {
                var value = await _skillService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Skill information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving skill information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSkill(CreateSkillDto createSkillDto)
            {
            try
            {
                await _skillService.CreateAsync(createSkillDto);
                return Ok("Skill information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating skill information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            try
            {
                await _skillService.DeleteAsync(id);
                return Ok("Skill information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting skill information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSkill(UpdateSkillDto updateSkillDto)
        {
            try
            {
                await _skillService.UpdateAsync(updateSkillDto);
                return Ok("Skill information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating skill information: " + ex.Message);
            }
        }

    }
}