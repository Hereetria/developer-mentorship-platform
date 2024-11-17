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
    public interface ISubDescriptionDAL : IGenericRepositoryDAL<SubDescription, CreateSubDescriptionDto, UpdateSubDescriptionDto, ResultSubDescriptionDto, ResultSubDescriptionByIdDto, int>
    {
    }

}
