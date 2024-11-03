

namespace MentorProjectWebApp.Dtos.FeatureDtos
{
    public class ResultEngagementDto
    {
        public  int FeatureId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public int MembershipId { get; set; }
    }
}