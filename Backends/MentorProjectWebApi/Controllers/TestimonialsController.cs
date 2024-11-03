

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.TestimonialDtos;
using DataAccessLayer.Services.TestimonialServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly ITestimonialService _testimonialService;

        public TestimonialsController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTestimonialInfo()
        {
            try
            {
                var values = await _testimonialService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing testimonial information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonialById(int id)
        {
            try
            {
                var value = await _testimonialService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Testimonial information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving testimonial information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
            {
            try
            {
                await _testimonialService.CreateAsync(createTestimonialDto);
                return Ok("Testimonial information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating testimonial information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            try
            {
                await _testimonialService.DeleteAsync(id);
                return Ok("Testimonial information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting testimonial information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            try
            {
                await _testimonialService.UpdateAsync(updateTestimonialDto);
                return Ok("Testimonial information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating testimonial information: " + ex.Message);
            }
        }

    }
}