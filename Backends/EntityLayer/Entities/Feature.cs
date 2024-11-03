using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Title { get; set; }

        public ICollection<SubDescription> SubDescriptions { get; set; } = new List<SubDescription>();  
    }
}
