using MentorProjectWebApp.Dtos.MentorContentDtos;
using MentorProjectWebApp.Dtos.MentorSkillDtos;
using MentorProjectWebApp.Dtos.MentorSocialMediaDtos;
using MentorProjectWebApp.Dtos.MentorStatisticDtos;
using MentorProjectWebApp.Dtos.SkillDtos;
using MentorProjectWebApp.Dtos.SocialMediaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorProjectWebApp.Dtos.MentorDtos
{
    public class ResultMentorWithRelationsDto
    {
        public int MentorId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public string PhotoPath { get; set; }

        public ICollection<ResultSocialMediaWithRelationsDto> SocialMedias { get; set; } = new List<ResultSocialMediaWithRelationsDto>();
        public ICollection<ResultMentorContentWithRelationsDto> MentorContents { get; set; } = new List<ResultMentorContentWithRelationsDto>();
        public ResultMentorStatisticDto MentorStatistic { get; set; }
        public ICollection<ResultSkillDto> Skills { get; set; } = new List<ResultSkillDto>();
    }

}
