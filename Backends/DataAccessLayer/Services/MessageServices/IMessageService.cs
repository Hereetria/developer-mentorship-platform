
using DtoLayer.Dtos.MessageDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.MessageServices
{
    
    public interface IMessageService : IGenericRepository<CreateMessageDto, UpdateMessageDto, ResultMessageDto, ResultMessageByIdDto, int>

    {

    }
}