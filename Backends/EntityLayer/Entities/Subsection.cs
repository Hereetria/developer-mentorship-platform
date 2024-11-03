using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Subsection
    {
        public int SubsectionId { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }

        public int MentorContentId { get; set; }
        public MentorContent MentorContent { get; set; }
    }
}
