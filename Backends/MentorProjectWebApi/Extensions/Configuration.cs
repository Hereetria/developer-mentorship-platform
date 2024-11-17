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
using BussinessLayer.Services.MentorContentServices;
using BussinessLayer.Services.MentorServices;
using BussinessLayer.Services.MembershipServices;
using BussinessLayer.Services.FeatureServices;
using BussinessLayer.Services.EngagementServices;
using BussinessLayer.Services.CategoryServices;
using BussinessLayer.Services.CarouselServices;
using BussinessLayer.Services.ArticleTagServices;
using BussinessLayer.Services.ArticleDetailServices;
using BussinessLayer.Services.ArticleContentServices;
using BussinessLayer.Services.ArticleCommentServices;
using BussinessLayer.Services.ArticleServices;
using BussinessLayer.Services.AboutUsServices;
using BussinessLayer.Services.MentorSkillServices;
using BussinessLayer.Services.MentorSocialMediaServices;
using BussinessLayer.Services.MentorStatisticServices;
using BussinessLayer.Services.MessageServices;
using BussinessLayer.Services.ServiceServices;
using BussinessLayer.Services.SkillServices;
using BussinessLayer.Services.SocialMediaServices;
using BussinessLayer.Services.SubDescriptionServices;
using BussinessLayer.Services.SubsectionServices;
using BussinessLayer.Services.TagServices;
using BussinessLayer.Services.TestimonialServices;
using BussinessLayer.Repositories;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;
using DataAccessLayer.Factories.Concrete;
using EntityLayer.Entities;

namespace MentorProjectWebApi.Extensions
{
        public class Configuration
    {

        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<Context>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddAutoMapper(typeof(GeneralMapping));

            builder.Services.AddScoped<IGenericRepositoryDALFactory, GenericRepositoryDALFactory>();

            builder.Services.AddScoped(typeof(IGenericRepositoryDAL<,,,,,>), typeof(GenericRepositoryDAL<,,,,,>));

            builder.Services.AddScoped<IAboutUsManager, AboutUsManager>();
            builder.Services.AddScoped<IArticleManager, ArticleManager>();
            builder.Services.AddScoped<IArticleCommentManager, ArticleCommentManager>();
            builder.Services.AddScoped<IArticleContentManager, ArticleContentManager>();
            builder.Services.AddScoped<IArticleDetailManager, ArticleDetailManager>();
            builder.Services.AddScoped<IArticleTagManager, ArticleTagManager>();
            builder.Services.AddScoped<ICarouselManager, CarouselManager>();
            builder.Services.AddScoped<ICategoryManager, CategoryManager>();
            builder.Services.AddScoped<IEngagementManager, EngagementManager>();
            builder.Services.AddScoped<IFeatureManager, FeatureManager>();
            builder.Services.AddScoped<IMembershipManager, MembershipManager>();
            builder.Services.AddScoped<IMentorManager, MentorManager>();
            builder.Services.AddScoped<IMentorContentManager, MentorContentManager>();
            builder.Services.AddScoped<IMentorSkillManager, MentorSkillManager>();
            builder.Services.AddScoped<IMentorSocialMediaManager, MentorSocialMediaManager>();
            builder.Services.AddScoped<IMentorStatisticManager, MentorStatisticManager>();
            builder.Services.AddScoped<IMessageManager, MessageManager>();
            builder.Services.AddScoped<IServiceManager, ServiceManager>();
            builder.Services.AddScoped<ISkillManager, SkillManager>();
            builder.Services.AddScoped<ISocialMediaManager, SocialMediaManager>();
            builder.Services.AddScoped<ISubDescriptionManager, SubDescriptionManager>();
            builder.Services.AddScoped<ISubsectionManager, SubsectionManager>();
            builder.Services.AddScoped<ITagManager, TagManager>();
            builder.Services.AddScoped<ITestimonialManager, TestimonialManager>();

            builder.Services.AddScoped<IAboutUsDAL, AboutUsDAL>();
            builder.Services.AddScoped<IArticleDAL, ArticleDAL>();
            builder.Services.AddScoped<IArticleCommentDAL, ArticleCommentDAL>();
            builder.Services.AddScoped<IArticleContentDAL, ArticleContentDAL>();
            builder.Services.AddScoped<IArticleDetailDAL, ArticleDetailDAL>();
            builder.Services.AddScoped<IArticleTagDAL, ArticleTagDAL>();
            builder.Services.AddScoped<ICategoryDAL, CategoryDAL>();
            builder.Services.AddScoped<IEngagementDAL, EngagementDAL>();
            builder.Services.AddScoped<ICarouselDAL, CarouselDAL>();
            builder.Services.AddScoped<IMembershipDAL, MembershipDAL>();
            builder.Services.AddScoped<IMentorDAL, MentorDAL>();
            builder.Services.AddScoped<IMentorContentDAL, MentorContentDAL>();
            builder.Services.AddScoped<IMentorSkillDAL, MentorSkillDAL>();
            builder.Services.AddScoped<IMentorSocialMediaDAL, MentorSocialMediaDAL>();
            builder.Services.AddScoped<IMentorStatisticDAL, MentorStatisticDAL>();
            builder.Services.AddScoped<IMessageDAL, MessageDAL>();
            builder.Services.AddScoped<IServiceDAL, ServiceDAL>();
            builder.Services.AddScoped<ISkillDAL, SkillDAL>();
            builder.Services.AddScoped<ISocialMediaDAL, SocialMediaDAL>();
            builder.Services.AddScoped<ISubsectionDAL, SubsectionDAL>();
            builder.Services.AddScoped<ITagDAL, TagDAL>();
            builder.Services.AddScoped<ITestimonialDAL, TestimonialDAL>();
            builder.Services.AddScoped<IFeatureDAL, FeatureDAL>();
            builder.Services.AddScoped<ISubDescriptionDAL, SubDescriptionDAL>();
        }
    }
}