

namespace MentorProjectWebApp.Dtos.MentorStatisticDtos
{
    public class CreateMentorStatisticDto
    {
        public int ClientsServed { get; set; }
        public int CompletedProjects { get; set; }
        public int SupportHoursProvided { get; set; }
        public int ActiveClients { get; set; }
        public int MentorId { get; set; }
    }
}