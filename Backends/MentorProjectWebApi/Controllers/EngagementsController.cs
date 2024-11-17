

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.FeatureDtos;
using DataAccessLayer.Services.FeatureServices;
using BussinessLayer.Services.EngagementServices;
using DtoLayer.Dtos.EngagementDtos;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class EngagementsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IEngagementManager _featureService;

        public EngagementsController(IEngagementManager featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetFeatureInfo()
        {
            try
            {
                var values = await _featureService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing feature information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatureById(int id)
        {
            try
            {
                var value = await _featureService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Feature information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving feature information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateEngagementDto createFeatureDto)
            {
            try
            {
                await _featureService.CreateAsync(createFeatureDto);
                return Ok("Feature information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating feature information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            try
            {
                await _featureService.DeleteAsync(id);
                return Ok("Feature information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting feature information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateEngagementDto updateFeatureDto)
        {
            try
            {
                await _featureService.UpdateAsync(updateFeatureDto);
                return Ok("Feature information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating feature information: " + ex.Message);
            }
        }

    }
}