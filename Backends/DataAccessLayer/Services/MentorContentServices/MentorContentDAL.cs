

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorContentDtos;
using DataAccessLayer.Services.MentorContentServices;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.MentorContentServices
{

    public class MentorContentDAL : GenericRepositoryDAL<MentorContent, CreateMentorContentDto, UpdateMentorContentDto, ResultMentorContentDto, ResultMentorContentByIdDto, int>, IMentorContentDAL

    {

        public MentorContentDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultMentorContentWithRelationsDto>> TGetMentorContentWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultMentorContentWithRelationsDto>(
                query: q => q
                    .Include(mc => mc.Mentor)
                    .Include(mc => mc.Subsections)
            );

            return result;
        }

        public async Task<ResultMentorContentWithRelationsByIdDto> TGetMentorContentWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultMentorContentWithRelationsByIdDto>(
                query: q => q
                    .Include(mc => mc.Mentor)
                    .Include(mc => mc.Subsections)
                    .Where(mc => mc.MentorContentId == id)
            );

            return result;
        }
    }
}