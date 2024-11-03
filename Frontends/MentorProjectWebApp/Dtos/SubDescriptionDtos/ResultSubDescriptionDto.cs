using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorProjectWebApp.Dtos.SubDescriptionDtos
{
    public class ResultSubDescriptionDto
    {
        public int SubDescriptionId { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
    }
}
