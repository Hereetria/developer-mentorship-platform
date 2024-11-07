

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorSocialMediaDtos;
using DataAccessLayer.Services.MentorSocialMediaServices;
using DataAccessLayer.Repositories.Concrete;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.SocialMediaDtos;

namespace DataAccessLayer.Services.MentorSocialMediaServices
{

    public class MentorSocialMediaService : GenericJunctionRepository<MentorSocialMedia, ResultMentorSocialMediaDto, CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto, int>, IMentorSocialMediaService
    {
        public MentorSocialMediaService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultMentorDto>> GetMentorListBySocialMediaIdAsync(int socialMediaId)
        {
            var mentors = await GetRelatedEntitiesByIdAsync(
                socialMediaId,
                entity => entity.SocialMediaId == socialMediaId,
                entity => entity.Mentor
            );

            var resultDtos = _mapper.Map<List<ResultMentorDto>>(mentors);
            return resultDtos;
        }

        public async Task<List<ResultSocialMediaDto>> GetSocialMediaListByMentorIdAsync(int mentorId)
        {
            var socialMedias = await GetRelatedEntitiesByIdAsync(
                mentorId,
                entity => entity.MentorId == mentorId,
                entity => entity.SocialMedia
            );

            var result = _mapper.Map<List<ResultSocialMediaDto>>(socialMedias);
            return result;
        }

        public async Task DeleteMentorSocialMediaAsync(DeleteMentorSocialMediaDto deleteDto)
        {
            if (deleteDto == null)
            {
                throw new ArgumentNullException(nameof(deleteDto), "DeleteMentorSocialMediaDto cannot be null.");
            }

            await DeleteAsync(
                entity => entity.MentorId == deleteDto.MentorId &&
                entity.SocialMediaId == deleteDto.SocialMediaId);
        }
    }
}