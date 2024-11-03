

namespace DtoLayer.Dtos.MentorContentDtos
{
    public class UpdateMentorContentDto
    {
        public int MentorContentId { get; set; }
        public string Header { get; set; }
        public string Summary { get; set; }
        public int MentorId { get; set; }
    }
}