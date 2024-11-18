

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorDtos;
using DataAccessLayer.Services.MentorServices;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.MentorServices
{

    public class MentorDAL : GenericRepositoryDAL<Mentor, CreateMentorDto, UpdateMentorDto, ResultMentorDto, ResultMentorByIdDto, int>, IMentorDAL

    {

        public MentorDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultMentorWithRelationsDto>> TGetMentorWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultMentorWithRelationsDto>(
                query: q => q
                    .Include(m => m.MentorSocialMedias)
                        .ThenInclude(ms => ms.SocialMedia)
                    .Include(m => m.MentorContents)
                    .Include(m => m.MentorStatistic)
                    .Include(m => m.MentorSkills)
                        .ThenInclude(ms => ms.Skill)
            );

            return result;
        }

        public async Task<ResultMentorWithRelationsByIdDto> TGetMentorWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultMentorWithRelationsByIdDto>(
                query: q => q
                    .Include(m => m.MentorSocialMedias)
                        .ThenInclude(ms => ms.SocialMedia)
                    .Include(m => m.MentorContents)
                    .Include(m => m.MentorStatistic)
                    .Include(m => m.MentorSkills)
                        .ThenInclude(ms => ms.Skill)
                    .Where(m => m.MentorId == id)
            );

            return result;
        }

    }
}