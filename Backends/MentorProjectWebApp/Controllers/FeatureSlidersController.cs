

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.FeatureSliderDtos;
using .Services.FeatureSliderServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureSlidersController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IFeatureSliderService _featureSliderService;

        public FeatureSlidersController(IFeatureSliderService featureSliderService, IMapper mapper)
        {
            _featureSliderService = featureSliderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetFeatureSliderInfo()
        {
            try
            {
                var values = await _featureSliderService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing featureSlider information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatureSliderById(int id)
        {
            try
            {
                var value = await _featureSliderService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"FeatureSlider information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving featureSlider information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeatureSlider(CreateFeatureSliderDto createFeatureSliderDto)
            {
            try
            {
                await _featureSliderService.CreateAsync(createFeatureSliderDto);
                return Ok("FeatureSlider information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating featureSlider information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeatureSlider(int id)
        {
            try
            {
                await _featureSliderService.DeleteAsync(id);
                return Ok("FeatureSlider information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting featureSlider information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeatureSlider(UpdateFeatureSliderDto updateFeatureSliderDto)
        {
            try
            {
                await _featureSliderService.UpdateAsync(updateFeatureSliderDto);
                return Ok("FeatureSlider information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating featureSlider information: " + ex.Message);
            }
        }

    }
}