

namespace DtoLayer.Dtos.EngagementDtos
{
    public class ResultEngagementDto
    {
        public  int EngagementId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public int MembershipId { get; set; }
    }
}