using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Mentor
    {
        public int MentorId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public string PhotoPath { get; set; }

        public ICollection<MentorSocialMedia> MentorSocialMedias { get; set; } = new List<MentorSocialMedia>();
        public ICollection<MentorContent> MentorContents { get; set; } = new List<MentorContent>();
        public MentorStatistic MentorStatistic { get; set; }
        public ICollection<MentorSkill> MentorSkills { get; set; } = new List<MentorSkill>();
    }
}
