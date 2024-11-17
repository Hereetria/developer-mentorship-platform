namespace MentorProjectWebApp.Services.MessageServices
{
    using MentorProjectWebApp.Dtos.MessageDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;

    public class MessageService : GenericRepository<CreateMessageDto, UpdateMessageDto, ResultMessageDto, ResultMessageByIdDto, int>, IMessageService
    {
        public MessageService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "messages")
        {
        }
    }

}
