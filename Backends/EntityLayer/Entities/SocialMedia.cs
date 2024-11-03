using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string Name { get; set; }
        public string IconPath { get; set; }
        public string Url { get; set; }

        public List<MentorSocialMedia> mentorSocialMedias { get; set; }
    }
}
