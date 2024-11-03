using AutoMapper;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.SubDescriptionDtos;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.SubDescriptionServices
{
    public class SubDescriptionService : GenericRepository<SubDescription, CreateSubDescriptionDto, UpdateSubDescriptionDto, ResultSubDescriptionDto, ResultSubDescriptionByIdDto, int>, ISubDescriptionService
    {
        public SubDescriptionService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
