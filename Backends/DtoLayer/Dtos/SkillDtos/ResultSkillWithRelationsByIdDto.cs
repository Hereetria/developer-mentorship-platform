using DtoLayer.Dtos.MentorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.SkillDtos
{
    public class ResultSkillWithRelationsByIdDto
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public ICollection<ResultMentorDto> Mentors { get; set; } = new List<ResultMentorDto>();
    }
}
