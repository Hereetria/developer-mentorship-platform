

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.AboutUsDtos;
using .Services.AboutUsServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsesController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IAboutUsService _aboutUsService;

        public AboutUsesController(IAboutUsService aboutUsService, IMapper mapper)
        {
            _aboutUsService = aboutUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAboutUsInfo()
        {
            try
            {
                var values = await _aboutUsService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing aboutUs information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutUsById(int id)
        {
            try
            {
                var value = await _aboutUsService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"AboutUs information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving aboutUs information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutUs(CreateAboutUsDto createAboutUsDto)
            {
            try
            {
                await _aboutUsService.CreateAsync(createAboutUsDto);
                return Ok("AboutUs information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating aboutUs information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAboutUs(int id)
        {
            try
            {
                await _aboutUsService.DeleteAsync(id);
                return Ok("AboutUs information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting aboutUs information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAboutUs(UpdateAboutUsDto updateAboutUsDto)
        {
            try
            {
                await _aboutUsService.UpdateAsync(updateAboutUsDto);
                return Ok("AboutUs information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating aboutUs information: " + ex.Message);
            }
        }

    }
}