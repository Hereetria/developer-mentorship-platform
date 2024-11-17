using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Carousel
    {
        public int CarouselId { get; set; }
        public string Header {  get; set; }
        public string Description {  get; set; }
        public string ImageUrl { get; set; }
    }
}
