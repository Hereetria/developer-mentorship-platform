

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.MentorDtos;
using DataAccessLayer.Services.MentorServices;
using BussinessLayer.Services.MentorServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MentorsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMentorManager _mentorService;

        public MentorsController(IMentorManager mentorService, IMapper mapper)
        {
            _mentorService = mentorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMentorInfo()
        {
            try
            {
                var values = await _mentorService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing mentor information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMentorById(int id)
        {
            try
            {
                var value = await _mentorService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Mentor information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving mentor information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateMentor(CreateMentorDto createMentorDto)
            {
            try
            {
                await _mentorService.CreateAsync(createMentorDto);
                return Ok("Mentor information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating mentor information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMentor(int id)
        {
            try
            {
                await _mentorService.DeleteAsync(id);
                return Ok("Mentor information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting mentor information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMentor(UpdateMentorDto updateMentorDto)
        {
            try
            {
                await _mentorService.UpdateAsync(updateMentorDto);
                return Ok("Mentor information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating mentor information: " + ex.Message);
            }
        }

        [HttpGet("GetMentorWithRelations")]
        public async Task<IActionResult> GetMentorWithRelations()
        {
            try
            {
                var values = await _mentorService.GetMentorWithRelationsAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing Mentor information with relations: " + ex.Message);
            }
        }

        [HttpGet("GetMentorWithRelationsById/{id}")]
        public async Task<IActionResult> GetMentorWithRelationsById(int id)
        {
            try
            {
                var values = await _mentorService.GetMentorWithRelationsByIdAsync(id);
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing Mentor information: " + ex.Message);
            }
        }
    }
}