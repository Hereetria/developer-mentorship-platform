using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class MentorSkill
    {
        public int MentorId { get; set; }
        public Mentor Mentor { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        [Range(0, 100, ErrorMessage = "Rate must be between 0-100")]
        public int Rate { get; set; }
    }
}
