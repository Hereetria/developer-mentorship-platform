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
        public string ClassName { get; set; }
        public string IconUrl { get; set; }

        public List<MentorSocialMedia> MentorSocialMedias { get; set; }
    }
}
