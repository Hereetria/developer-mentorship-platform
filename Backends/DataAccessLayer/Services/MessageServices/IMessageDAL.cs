
using DtoLayer.Dtos.MessageDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.MessageServices
{

    public interface IMessageDAL : IGenericRepositoryDAL<Message, CreateMessageDto, UpdateMessageDto, ResultMessageDto, ResultMessageByIdDto, int>

    {

    }
}