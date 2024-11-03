

namespace DtoLayer.Dtos.CarouselDtos
{
    public class UpdateCarouselDto
    {
        public int CarouselId { get; set; }
        public int Header {  get; set; }
        public string Description {  get; set; }
        public string ButtonDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}