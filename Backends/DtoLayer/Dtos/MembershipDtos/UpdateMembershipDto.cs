

namespace DtoLayer.Dtos.MembershipDtos
{
    public class UpdateMembershipDto
    {
        public int MembershipId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string? Level { get; set; }
    }
}