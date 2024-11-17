using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.MentorContentDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.MentorContentServices
{
    public class MentorContentManager : GenericRepositoryBL<MentorContent, CreateMentorContentDto, UpdateMentorContentDto, ResultMentorContentDto, ResultMentorContentByIdDto, int>, IMentorContentManager
    {
        public MentorContentManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultMentorContentWithRelationsDto>> GetMentorContentWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultMentorContentWithRelationsDto>(
                query: q => q
                    .Include(mc => mc.Mentor)
                    .Include(mc => mc.Subsections)
            );

            return result;
        }

        public async Task<ResultMentorContentWithRelationsByIdDto> GetMentorContentWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultMentorContentWithRelationsByIdDto>(
                query: q => q
                    .Include(mc => mc.Mentor)
                    .Include(mc => mc.Subsections)
                    .Where(mc => mc.MentorContentId == id)
            );

            return result;
        }
    }
}