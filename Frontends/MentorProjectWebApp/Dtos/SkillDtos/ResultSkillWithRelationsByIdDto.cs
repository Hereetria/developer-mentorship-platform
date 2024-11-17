using MentorProjectWebApp.Dtos.MentorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorProjectWebApp.Dtos.SkillDtos
{
    public class ResultSkillWithRelationsByIdDto
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public ICollection<ResultMentorDto> Mentors { get; set; } = new List<ResultMentorDto>();
    }
}
