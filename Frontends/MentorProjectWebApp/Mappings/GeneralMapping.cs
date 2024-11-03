
using AutoMapper;
using EntityLayer.Entities;
using MentorProjectWebApp.Dtos.AboutUsDtos;
using MentorProjectWebApp.Dtos.ArticleDtos;
using MentorProjectWebApp.Dtos.ArticleCommentDtos;
using MentorProjectWebApp.Dtos.ArticleContentDtos;
using MentorProjectWebApp.Dtos.ArticleDetailDtos;
using MentorProjectWebApp.Dtos.ArticleTagDtos;
using MentorProjectWebApp.Dtos.CategoryDtos;
using MentorProjectWebApp.Dtos.FeatureDtos;
using MentorProjectWebApp.Dtos.CarouselDtos;
using MentorProjectWebApp.Dtos.MembershipDtos;
using MentorProjectWebApp.Dtos.MentorDtos;
using MentorProjectWebApp.Dtos.MentorContentDtos;
using MentorProjectWebApp.Dtos.MentorSkillDtos;
using MentorProjectWebApp.Dtos.MentorSocialMediaDtos;
using MentorProjectWebApp.Dtos.MentorStatisticDtos;
using MentorProjectWebApp.Dtos.MessageDtos;
using MentorProjectWebApp.Dtos.ServiceDtos;
using MentorProjectWebApp.Dtos.SkillDtos;
using MentorProjectWebApp.Dtos.SocialMediaDtos;
using MentorProjectWebApp.Dtos.SubsectionDtos;
using MentorProjectWebApp.Dtos.TagDtos;
using MentorProjectWebApp.Dtos.TestimonialDtos;

namespace MentorProjectWebApp.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<AboutUs, ResultAboutUsDto>().ReverseMap();
            CreateMap<AboutUs, ResultAboutUsByIdDto>().ReverseMap();
            CreateMap<AboutUs, CreateAboutUsDto>().ReverseMap();
            CreateMap<AboutUs, UpdateAboutUsDto>().ReverseMap();

            CreateMap<Article, ResultArticleDto>().ReverseMap();
            CreateMap<Article, ResultArticleByIdDto>().ReverseMap();
            CreateMap<Article, CreateArticleDto>().ReverseMap();
            CreateMap<Article, UpdateArticleDto>().ReverseMap();

            CreateMap<ArticleComment, ResultArticleCommentDto>().ReverseMap();
            CreateMap<ArticleComment, ResultArticleCommentByIdDto>().ReverseMap();
            CreateMap<ArticleComment, CreateArticleCommentDto>().ReverseMap();
            CreateMap<ArticleComment, UpdateArticleCommentDto>().ReverseMap();

            CreateMap<ArticleContent, ResultArticleContentDto>().ReverseMap();
            CreateMap<ArticleContent, ResultArticleContentByIdDto>().ReverseMap();
            CreateMap<ArticleContent, CreateArticleContentDto>().ReverseMap();
            CreateMap<ArticleContent, UpdateArticleContentDto>().ReverseMap();

            CreateMap<ArticleDetail, ResultArticleDetailDto>().ReverseMap();
            CreateMap<ArticleDetail, ResultArticleDetailByIdDto>().ReverseMap();
            CreateMap<ArticleDetail, CreateArticleDetailDto>().ReverseMap();
            CreateMap<ArticleDetail, UpdateArticleDetailDto>().ReverseMap();

            CreateMap<ArticleTag, ResultArticleTagDto>().ReverseMap();
            CreateMap<ArticleTag, ResultArticleTagByIdDto>().ReverseMap();
            CreateMap<ArticleTag, CreateArticleTagDto>().ReverseMap();
            CreateMap<ArticleTag, UpdateArticleTagDto>().ReverseMap();

            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryByIdDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<Engagement, ResultFeatureDto>().ReverseMap();
            CreateMap<Engagement, ResultFeatureByIdDto>().ReverseMap();
            CreateMap<Engagement, CreateFeatureDto>().ReverseMap();
            CreateMap<Engagement, UpdateFeatureDto>().ReverseMap();

            CreateMap<Carousel, ResultCarouselDto>().ReverseMap();
            CreateMap<Carousel, ResultCarouselByIdDto>().ReverseMap();
            CreateMap<Carousel, CreateCarouselDto>().ReverseMap();
            CreateMap<Carousel, UpdateCarouselDto>().ReverseMap();

            CreateMap<Membership, ResultMembershipDto>().ReverseMap();
            CreateMap<Membership, ResultMembershipByIdDto>().ReverseMap();
            CreateMap<Membership, CreateMembershipDto>().ReverseMap();
            CreateMap<Membership, UpdateMembershipDto>().ReverseMap();

            CreateMap<Mentor, ResultMentorDto>().ReverseMap();
            CreateMap<Mentor, ResultMentorByIdDto>().ReverseMap();
            CreateMap<Mentor, CreateMentorDto>().ReverseMap();
            CreateMap<Mentor, UpdateMentorDto>().ReverseMap();

            CreateMap<MentorContent, ResultMentorContentDto>().ReverseMap();
            CreateMap<MentorContent, ResultMentorContentByIdDto>().ReverseMap();
            CreateMap<MentorContent, CreateMentorContentDto>().ReverseMap();
            CreateMap<MentorContent, UpdateMentorContentDto>().ReverseMap();

            CreateMap<MentorSkill, ResultMentorSkillDto>().ReverseMap();
            CreateMap<MentorSkill, ResultMentorSkillByIdDto>().ReverseMap();
            CreateMap<MentorSkill, CreateMentorSkillDto>().ReverseMap();
            CreateMap<MentorSkill, UpdateMentorSkillDto>().ReverseMap();

            CreateMap<MentorSocialMedia, ResultMentorSocialMediaDto>().ReverseMap();
            CreateMap<MentorSocialMedia, ResultMentorSocialMediaByIdDto>().ReverseMap();
            CreateMap<MentorSocialMedia, CreateMentorSocialMediaDto>().ReverseMap();
            CreateMap<MentorSocialMedia, UpdateMentorSocialMediaDto>().ReverseMap();

            CreateMap<MentorStatistic, ResultMentorStatisticDto>().ReverseMap();
            CreateMap<MentorStatistic, ResultMentorStatisticByIdDto>().ReverseMap();
            CreateMap<MentorStatistic, CreateMentorStatisticDto>().ReverseMap();
            CreateMap<MentorStatistic, UpdateMentorStatisticDto>().ReverseMap();

            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, ResultMessageByIdDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();

            CreateMap<Service, ResultServiceDto>().ReverseMap();
            CreateMap<Service, ResultServiceByIdDto>().ReverseMap();
            CreateMap<Service, CreateServiceDto>().ReverseMap();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();

            CreateMap<Skill, ResultSkillDto>().ReverseMap();
            CreateMap<Skill, ResultSkillByIdDto>().ReverseMap();
            CreateMap<Skill, CreateSkillDto>().ReverseMap();
            CreateMap<Skill, UpdateSkillDto>().ReverseMap();

            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, ResultSocialMediaByIdDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();

            CreateMap<Subsection, ResultSubsectionDto>().ReverseMap();
            CreateMap<Subsection, ResultSubsectionByIdDto>().ReverseMap();
            CreateMap<Subsection, CreateSubsectionDto>().ReverseMap();
            CreateMap<Subsection, UpdateSubsectionDto>().ReverseMap();

            CreateMap<Tag, ResultTagDto>().ReverseMap();
            CreateMap<Tag, ResultTagByIdDto>().ReverseMap();
            CreateMap<Tag, CreateTagDto>().ReverseMap();
            CreateMap<Tag, UpdateTagDto>().ReverseMap();

            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, ResultTestimonialByIdDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();

        }
    }
}