

namespace DtoLayer.Dtos.MentorStatisticDtos
{
    public class UpdateMentorStatisticDto
    {
        public int MentorStatisticId { get; set; }
        public int ClientsServed { get; set; }
        public int CompletedProjects { get; set; }
        public int SupportHoursProvided { get; set; }
        public int ActiveClients { get; set; }
        public int MentorId { get; set; }
    }
}