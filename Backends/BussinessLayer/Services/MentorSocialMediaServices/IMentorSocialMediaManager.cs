using BussinessLayer.Repositories;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.MentorSocialMediaDtos;
using DtoLayer.Dtos.SocialMediaDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.MentorSocialMediaServices
{
    public interface IMentorSocialMediaManager : IGenericRepositoryBL<MentorSocialMedia, CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto, ResultMentorSocialMediaDto, ResultMentorSocialMediaByIdDto, int>
    {
        Task<ResultMentorSocialMediaWithRelationsByIdDto> GetMentorSocialMediaWithRelationsByIdAsync(int id);
        Task<List<ResultMentorSocialMediaWithRelationsDto>> GetMentorSocialMediaWithRelationsAsync();

        Task<List<ResultSocialMediaDto>> GetSocialMediaListByMentorIdAsync(int mentorId);
        Task<List<ResultMentorDto>> GetMentorListBySocialMediaIdAsync(int socialMediaId);
    }
}