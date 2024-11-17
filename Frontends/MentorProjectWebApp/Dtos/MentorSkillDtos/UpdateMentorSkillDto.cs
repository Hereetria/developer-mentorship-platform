

namespace MentorProjectWebApp.Dtos.MentorSkillDtos
{
    public class UpdateMentorSkillDto
    {
        public int MentorSkillId { get; set; }
        public int MentorId { get; set; }
        public int SkillId { get; set; }
        public int Rate { get; set; }
    }
}