

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.SubsectionDtos;
using .Services.SubsectionServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class SubsectionsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly ISubsectionService _subsectionService;

        public SubsectionsController(ISubsectionService subsectionService, IMapper mapper)
        {
            _subsectionService = subsectionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetSubsectionInfo()
        {
            try
            {
                var values = await _subsectionService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing subsection information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubsectionById(int id)
        {
            try
            {
                var value = await _subsectionService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Subsection information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving subsection information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubsection(CreateSubsectionDto createSubsectionDto)
            {
            try
            {
                await _subsectionService.CreateAsync(createSubsectionDto);
                return Ok("Subsection information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating subsection information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubsection(int id)
        {
            try
            {
                await _subsectionService.DeleteAsync(id);
                return Ok("Subsection information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting subsection information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSubsection(UpdateSubsectionDto updateSubsectionDto)
        {
            try
            {
                await _subsectionService.UpdateAsync(updateSubsectionDto);
                return Ok("Subsection information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating subsection information: " + ex.Message);
            }
        }

    }
}