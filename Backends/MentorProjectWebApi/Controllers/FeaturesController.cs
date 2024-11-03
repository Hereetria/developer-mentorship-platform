using AutoMapper;
using DataAccessLayer.Services.FeatureServices;
using DtoLayer.Dtos.FeatureDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IFeatureService _featureService;

        public FeaturesController(IFeatureService featureService, IMapper mapper)
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
                return StatusCode(500, "An error occurred while listing Feature information: " + ex.Message);
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
                return StatusCode(500, "An error occurred while retrieving Feature information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            try
            {
                await _featureService.CreateAsync(createFeatureDto);
                return Ok("Feature information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating Feature information: " + ex.Message);
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
                return StatusCode(500, "An error occurred while deleting Feature information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            try
            {
                await _featureService.UpdateAsync(updateFeatureDto);
                return Ok("Feature information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating Feature information: " + ex.Message);
            }
        }
    }
}
