using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.MessageDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.MessageServices
{
    public class MessageManager : GenericRepositoryBL<Message, CreateMessageDto, UpdateMessageDto, ResultMessageDto, ResultMessageByIdDto, int>, IMessageManager
    {
        public MessageManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}