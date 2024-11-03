

namespace DtoLayer.Dtos.FeatureDtos
{
    public class CreateEngagementDto
    {
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public int MembershipId { get; set; }
    }
}