

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.CarouselDtos;
using DataAccessLayer.Services.CarouselServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CarouselsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly ICarouselService _carouselService;

        public CarouselsController(ICarouselService carouselService, IMapper mapper)
        {
            _carouselService = carouselService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarouselInfo()
        {
            try
            {
                var values = await _carouselService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing Carousel information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarouselById(int id)
        {
            try
            {
                var value = await _carouselService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Carousel information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving Carousel information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarousel(CreateCarouselDto createCarouselDto)
            {
            try
            {
                await _carouselService.CreateAsync(createCarouselDto);
                return Ok("Carousel information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating Carousel information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarousel(int id)
        {
            try
            {
                await _carouselService.DeleteAsync(id);
                return Ok("Carousel information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting Carousel information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCarousel(UpdateCarouselDto updateCarouselDto)
        {
            try
            {
                await _carouselService.UpdateAsync(updateCarouselDto);
                return Ok("Carousel information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating Carousel information: " + ex.Message);
            }
        }

    }
}