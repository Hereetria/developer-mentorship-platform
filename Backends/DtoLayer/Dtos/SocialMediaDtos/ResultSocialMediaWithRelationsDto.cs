using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.MentorSocialMediaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.SocialMediaDtos
{
    public class ResultSocialMediaWithRelationsDto
    {
        public int SocialMediaId { get; set; }
        public string ClassName { get; set; }
        public string IconUrl { get; set; }
        public ICollection<ResultMentorDto> Mentors{ get; set; } = new List<ResultMentorDto>();
    }
}
