using System;
using System.Collections.Generic;
using DataAccessLayer.Services.AboutUsServices;
using DataAccessLayer.Services.ArticleServices;
using DataAccessLayer.Services.ArticleCommentServices;
using DataAccessLayer.Services.ArticleContentServices;
using DataAccessLayer.Services.ArticleDetailServices;
using DataAccessLayer.Services.ArticleTagServices;
using DataAccessLayer.Services.CategoryServices;
using DataAccessLayer.Services.FeatureServices;
using DataAccessLayer.Services.MembershipServices;
using DataAccessLayer.Services.MentorServices;
using DataAccessLayer.Services.MentorContentServices;
using DataAccessLayer.Services.MentorSkillServices;
using DataAccessLayer.Services.MentorSocialMediaServices;
using DataAccessLayer.Services.MentorStatisticServices;
using DataAccessLayer.Services.MessageServices;
using DataAccessLayer.Services.ServiceServices;
using DataAccessLayer.Services.SkillServices;
using DataAccessLayer.Services.SocialMediaServices;
using DataAccessLayer.Services.SubsectionServices;
using DataAccessLayer.Services.TagServices;
using DataAccessLayer.Services.TestimonialServices;

using DtoLayer.Mappings;
using System.Reflection;


using DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DataAccessLayer.Services.SubDescriptionServices;
using DataAccessLayer.Services.CarouselServices;
namespace MentorProjectWebApi.Configurations
{
        public class Configuration
    {

        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<Context>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddAutoMapper(typeof(GeneralMapping));

            builder.Services.AddScoped<IAboutUsService, AboutUsService>();
            builder.Services.AddScoped<IArticleService, ArticleService>();
            builder.Services.AddScoped<IArticleCommentService, ArticleCommentService>();
            builder.Services.AddScoped<IArticleContentService, ArticleContentService>();
            builder.Services.AddScoped<IArticleDetailService, ArticleDetailService>();
            builder.Services.AddScoped<IArticleTagService, ArticleTagService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IEngagementService, EngagementService>();
            builder.Services.AddScoped<ICarouselService, CarouselService>();
            builder.Services.AddScoped<IMembershipService, MembershipService>();
            builder.Services.AddScoped<IMentorService, MentorService>();
            builder.Services.AddScoped<IMentorContentService, MentorContentService>();
            builder.Services.AddScoped<IMentorSkillService, MentorSkillService>();
            builder.Services.AddScoped<IMentorSocialMediaService, MentorSocialMediaService>();
            builder.Services.AddScoped<IMentorStatisticService, MentorStatisticService>();
            builder.Services.AddScoped<IMessageService, MessageService>();
            builder.Services.AddScoped<IServiceService, ServiceService>();
            builder.Services.AddScoped<ISkillService, SkillService>();
            builder.Services.AddScoped<ISocialMediaService, SocialMediaService>();
            builder.Services.AddScoped<ISubsectionService, SubsectionService>();
            builder.Services.AddScoped<ITagService, TagService>();
            builder.Services.AddScoped<ITestimonialService, TestimonialService>();
            builder.Services.AddScoped<IFeatureService, FeatureService>();
            builder.Services.AddScoped<ISubDescriptionService, SubDescriptionService>();
        }
    }
}