

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MessageDtos;
using DataAccessLayer.Services.MessageServices;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.MessageServices
{

    public class MessageDAL : GenericRepositoryDAL<Message, CreateMessageDto, UpdateMessageDto, ResultMessageDto, ResultMessageByIdDto, int>, IMessageDAL

    {

        public MessageDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}