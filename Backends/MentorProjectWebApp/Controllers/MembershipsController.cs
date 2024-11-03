

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.MembershipDtos;
using .Services.MembershipServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMembershipService _membershipService;

        public MembershipsController(IMembershipService membershipService, IMapper mapper)
        {
            _membershipService = membershipService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMembershipInfo()
        {
            try
            {
                var values = await _membershipService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing membership information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMembershipById(int id)
        {
            try
            {
                var value = await _membershipService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Membership information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving membership information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateMembership(CreateMembershipDto createMembershipDto)
            {
            try
            {
                await _membershipService.CreateAsync(createMembershipDto);
                return Ok("Membership information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating membership information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMembership(int id)
        {
            try
            {
                await _membershipService.DeleteAsync(id);
                return Ok("Membership information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting membership information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMembership(UpdateMembershipDto updateMembershipDto)
        {
            try
            {
                await _membershipService.UpdateAsync(updateMembershipDto);
                return Ok("Membership information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating membership information: " + ex.Message);
            }
        }

    }
}