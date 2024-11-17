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
    public class SubDescriptionDAL : GenericRepositoryDAL<SubDescription, CreateSubDescriptionDto, UpdateSubDescriptionDto, ResultSubDescriptionDto, ResultSubDescriptionByIdDto, int>, ISubDescriptionDAL
    {
        public SubDescriptionDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
