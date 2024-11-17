

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.ServiceDtos;
using DataAccessLayer.Services.ServiceServices;
using BussinessLayer.Services.ServiceServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IServiceManager _serviceService;

        public ServicesController(IServiceManager serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetServiceInfo()
        {
            try
            {
                var values = await _serviceService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing service information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceById(int id)
        {
            try
            {
                var value = await _serviceService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Service information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving service information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
            {
            try
            {
                await _serviceService.CreateAsync(createServiceDto);
                return Ok("Service information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating service information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            try
            {
                await _serviceService.DeleteAsync(id);
                return Ok("Service information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting service information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            try
            {
                await _serviceService.UpdateAsync(updateServiceDto);
                return Ok("Service information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating service information: " + ex.Message);
            }
        }

    }
}