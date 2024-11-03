namespace MentorProjectWebApp.Services.MessageServices
{
    using MentorProjectWebApp.Dtos.MessageDtos;
    using MentorProjectWebApp.Repositories;

    public interface IMessageService : IGenericRepository<CreateMessageDto, UpdateMessageDto, ResultMessageDto, ResultMessageByIdDto, int>
    {
    }

}
