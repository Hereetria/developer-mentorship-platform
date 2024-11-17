

namespace DtoLayer.Dtos.EngagementDtos
{
    public class CreateEngagementDto
    {
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public int MembershipId { get; set; }
    }
}