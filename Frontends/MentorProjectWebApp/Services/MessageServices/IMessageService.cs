namespace MentorProjectWebApp.Services.MessageServices
{
    using MentorProjectWebApp.Dtos.MessageDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface IMessageService : IGenericRepository<CreateMessageDto, UpdateMessageDto, ResultMessageDto, ResultMessageByIdDto, int>
    {
    }

}
