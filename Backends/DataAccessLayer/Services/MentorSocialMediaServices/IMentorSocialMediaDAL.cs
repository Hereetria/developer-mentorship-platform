
using DtoLayer.Dtos.MentorSocialMediaDtos;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.SocialMediaDtos;
using DtoLayer.Dtos.MentorSkillDtos;
using EntityLayer.Entities;
using DtoLayer.Dtos.ArticleTagDtos;

namespace DataAccessLayer.Services.MentorSocialMediaServices
{

    public interface IMentorSocialMediaDAL : IGenericRepositoryDAL<MentorSocialMedia, CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto, ResultMentorSocialMediaDto, ResultMentorSocialMediaByIdDto, int>
    {
        Task<ResultMentorSocialMediaWithRelationsByIdDto> TGetMentorSocialMediaWithRelationsByIdAsync(int id);
        Task<List<ResultMentorSocialMediaWithRelationsDto>> TGetMentorSocialMediaWithRelationsAsync();
        Task<List<ResultSocialMediaDto>> TGetSocialMediaListByMentorIdAsync(int mentorId);
        Task<List<ResultMentorDto>> TGetMentorListBySocialMediaIdAsync(int socialMediaId);
    }
}