

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MessageDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.MessageServices;

namespace DataAccessLayer.Services.MessageServices
{
    
    public class MessageService : GenericRepository<Message, CreateMessageDto, UpdateMessageDto, ResultMessageDto, ResultMessageByIdDto, int>, IMessageService

    {

        public MessageService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}