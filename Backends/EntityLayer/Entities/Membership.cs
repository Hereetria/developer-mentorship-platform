using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        [MaxLength(5, ErrorMessage = "Engagements cannot exceed 5 items.")]
        public ICollection<Engagement> Engagements { get; set; } = new List<Engagement>();
        public int? DiscountRate { get; set; }
        public string Level { get; set; }
    }
}
