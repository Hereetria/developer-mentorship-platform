using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Factories.Abstract
{
    public interface IGenericRepositoryDALFactory
    {
        IGenericRepositoryDAL<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey> CreateRepositoryDAL<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey>()
            where TEntity : class
            where TCreateDto : class
            where TUpdateDto : class
            where TResultDto : class
            where TResultById : class;
    }
}
