using DataAccessLayer.Repositories.Abstract;
using DtoLayer.Dtos.SubDescriptionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.SubDescriptionServices
{
    public interface ISubDescriptionService : IGenericRepository<CreateSubDescriptionDto, UpdateSubDescriptionDto, ResultSubDescriptionDto, ResultSubDescriptionByIdDto, int>
    {
    }

}
