using AutoMapper;
using DataAccessLayer.Services.SubDescriptionServices;
using DtoLayer.Dtos.SubDescriptionDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubDescriptionsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISubDescriptionService _subDescriptionService;

        public SubDescriptionsController(ISubDescriptionService subDescriptionService, IMapper mapper)
        {
            _subDescriptionService = subDescriptionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetSubDescriptionInfo()
        {
            try
            {
                var values = await _subDescriptionService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing SubDescription information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubDescriptionById(int id)
        {
            try
            {
                var value = await _subDescriptionService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"SubDescription information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving SubDescription information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubDescription(CreateSubDescriptionDto createSubDescriptionDto)
        {
            try
            {
                await _subDescriptionService.CreateAsync(createSubDescriptionDto);
                return Ok("SubDescription information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating SubDescription information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubDescription(int id)
        {
            try
            {
                await _subDescriptionService.DeleteAsync(id);
                return Ok("SubDescription information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting SubDescription information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSubDescription(UpdateSubDescriptionDto updateSubDescriptionDto)
        {
            try
            {
                await _subDescriptionService.UpdateAsync(updateSubDescriptionDto);
                return Ok("SubDescription information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating SubDescription information: " + ex.Message);
            }
        }
    }

}
