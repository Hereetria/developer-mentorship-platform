using MentorProjectWebApp.Dtos.MentorDtos;
using MentorProjectWebApp.Dtos.SocialMediaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorProjectWebApp.Dtos.MentorSocialMediaDtos
{
    public class ResultMentorSocialMediaWithRelationsByIdDto
    {
        public int MentorSocialMediaId { get; set; }

        public int MentorId { get; set; }
        public ResultMentorDto Mentor { get; set; }

        public int SocialMediaId { get; set; }
        public ResultSocialMediaDto SocialMedia { get; set; }
    }
}
