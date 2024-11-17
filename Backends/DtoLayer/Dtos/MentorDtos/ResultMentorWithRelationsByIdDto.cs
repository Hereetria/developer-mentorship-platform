using DtoLayer.Dtos.MentorContentDtos;
using DtoLayer.Dtos.MentorStatisticDtos;
using DtoLayer.Dtos.SkillDtos;
using DtoLayer.Dtos.SocialMediaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.MentorDtos
{
    public class ResultMentorWithRelationsByIdDto
    {
        public int MentorId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public string PhotoPath { get; set; }

        public ICollection<ResultSocialMediaDto> SocialMedias { get; set; } = new List<ResultSocialMediaDto>();
        public ICollection<ResultMentorContentWithRelationsDto> MentorContents { get; set; } = new List<ResultMentorContentWithRelationsDto>();
        public ResultMentorStatisticDto MentorStatistic { get; set; }
        public ICollection<ResultSkillDto> Skills { get; set; } = new List<ResultSkillDto>();
    }
}
