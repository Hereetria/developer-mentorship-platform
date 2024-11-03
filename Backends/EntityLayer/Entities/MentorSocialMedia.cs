using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class MentorSocialMedia
    {
        public int MentorId { get; set; }
        public Mentor Mentor { get; set; }

        public int SocialMediaId { get; set; }
        public SocialMedia SocialMedia { get; set; }
    }
}
