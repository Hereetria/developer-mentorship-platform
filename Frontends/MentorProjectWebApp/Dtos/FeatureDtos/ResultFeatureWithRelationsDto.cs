using MentorProjectWebApp.Dtos.SubDescriptionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorProjectWebApp.Dtos.FeatureDtos
{
    public class ResultFeatureWithRelationsDto
    {
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public List<ResultSubDescriptionDto> SubDescriptions { get; set; }
    }

}
