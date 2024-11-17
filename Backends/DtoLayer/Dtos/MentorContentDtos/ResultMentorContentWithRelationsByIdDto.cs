using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.SubsectionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.MentorContentDtos
{
    public class ResultMentorContentWithRelationsByIdDto
    {
        public int MentorContentId { get; set; }
        public string Header { get; set; }
        public string Summary { get; set; }
        public int MentorId { get; set; }
        public List<ResultSubsectionDto> Subsections { get; set; } = new List<ResultSubsectionDto>();
    }
}
