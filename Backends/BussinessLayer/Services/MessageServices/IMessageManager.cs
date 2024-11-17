using BussinessLayer.Repositories;
using DtoLayer.Dtos.MessageDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.MessageServices
{
    public interface IMessageManager : IGenericRepositoryBL<Message, CreateMessageDto, UpdateMessageDto, ResultMessageDto, ResultMessageByIdDto, int>
    {
    }
}
