

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.MembershipDtos;
using DataAccessLayer.Services.MembershipServices;
using BussinessLayer.Services.MembershipServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMembershipManager _membershipService;

        public MembershipsController(IMembershipManager membershipService, IMapper mapper)
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

        [HttpGet("GetMembershipWithRelations")]
        public async Task<IActionResult> GetMembershipWithRelations()
        {
            try
            {
                var values = await _membershipService.GetMembershipWithRelationsAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing Membership information: " + ex.Message);
            }
        }

        [HttpGet("GetMembershipWithRelationsById/{id}")]
        public async Task<IActionResult> GetMembershipWithRelationsById(int id)
        {
            try
            {
                var values = await _membershipService.GetMembershipWithRelationsByIdAsync(id);
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing Membership information: " + ex.Message);
            }
        }

    }
}