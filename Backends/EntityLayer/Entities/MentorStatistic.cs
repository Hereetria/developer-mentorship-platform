using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class MentorStatistic
    {
        public int MentorStatisticId { get; set; }
        public int ClientsServed { get; set; }
        public int CompletedProjects { get; set; }
        public int SupportHoursProvided { get; set; }
        public int ActiveClients { get; set; }

        public int MentorId { get; set; }
        public Mentor Mentor { get; set; }
    }
}
