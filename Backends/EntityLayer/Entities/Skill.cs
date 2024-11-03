using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }

        public List<MentorSkill> MentorSkills { get; set; } = new List<MentorSkill>();
    }

}
