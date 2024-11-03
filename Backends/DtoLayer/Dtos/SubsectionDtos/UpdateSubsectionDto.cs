

namespace DtoLayer.Dtos.SubsectionDtos
{
    public class UpdateSubsectionDto
    {
        public int SubsectionId { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public int MentorContentId { get; set; }
    }
}