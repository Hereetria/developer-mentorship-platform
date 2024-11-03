

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.MentorStatisticDtos;
using .Services.MentorStatisticServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MentorStatisticsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMentorStatisticService _mentorStatisticService;

        public MentorStatisticsController(IMentorStatisticService mentorStatisticService, IMapper mapper)
        {
            _mentorStatisticService = mentorStatisticService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMentorStatisticInfo()
        {
            try
            {
                var values = await _mentorStatisticService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing mentorStatistic information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMentorStatisticById(int id)
        {
            try
            {
                var value = await _mentorStatisticService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"MentorStatistic information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving mentorStatistic information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateMentorStatistic(CreateMentorStatisticDto createMentorStatisticDto)
            {
            try
            {
                await _mentorStatisticService.CreateAsync(createMentorStatisticDto);
                return Ok("MentorStatistic information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating mentorStatistic information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMentorStatistic(int id)
        {
            try
            {
                await _mentorStatisticService.DeleteAsync(id);
                return Ok("MentorStatistic information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting mentorStatistic information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMentorStatistic(UpdateMentorStatisticDto updateMentorStatisticDto)
        {
            try
            {
                await _mentorStatisticService.UpdateAsync(updateMentorStatisticDto);
                return Ok("MentorStatistic information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating mentorStatistic information: " + ex.Message);
            }
        }

    }
}