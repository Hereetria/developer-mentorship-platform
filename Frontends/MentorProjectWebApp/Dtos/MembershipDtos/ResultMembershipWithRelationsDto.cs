using MentorProjectWebApp.Dtos.EngagementDtos;
using MentorProjectWebApp.Dtos.FeatureDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorProjectWebApp.Dtos.MembershipDtos
{
    public class ResultMembershipWithRelationsDto
    {
        public int MembershipId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int? DiscountRate { get; set; }
        public string? Level { get; set; }
        public List<ResultEngagementDto> Engagements { get; set; }
    }

}
