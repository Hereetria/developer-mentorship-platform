using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class MentorContent
    {
        public int MentorContentId { get; set; }
        public string Header { get; set; }
        public string Summary { get; set; }

        public int MentorId { get; set; }
        public Mentor Mentor { get; set; }

        public ICollection<Subsection> Subsections { get; set; } = new List<Subsection>();

    }

}
