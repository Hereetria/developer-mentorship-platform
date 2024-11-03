using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Engagement
    {
        public  int EngagementId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;

        public int MembershipId { get; set; }
        public Membership Membership { get; set; }
    }
}
