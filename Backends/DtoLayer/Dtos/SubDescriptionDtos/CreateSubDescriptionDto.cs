using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.SubDescriptionDtos
{
    public class CreateSubDescriptionDto
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
        public int FeatureId { get; set; }
    }
}
