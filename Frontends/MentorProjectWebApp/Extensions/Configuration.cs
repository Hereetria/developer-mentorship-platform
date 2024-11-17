using MentorProjectWebApp.Handlers;
using MentorProjectWebApp.Services.AboutUsServices;
using MentorProjectWebApp.Services.ArticleCommentServices;
using MentorProjectWebApp.Services.ArticleContentServices;
using MentorProjectWebApp.Services.ArticleDetailServices;
using MentorProjectWebApp.Services.ArticleServices;
using MentorProjectWebApp.Services.ArticleTagServices;
using MentorProjectWebApp.Services.CarouselServices;
using MentorProjectWebApp.Services.CategoryServices;
using MentorProjectWebApp.Services.EngagementServices;
using MentorProjectWebApp.Services.FeatureServices;
using MentorProjectWebApp.Services.MembershipServices;
using MentorProjectWebApp.Services.MentorContentServices;
using MentorProjectWebApp.Services.MentorServices;
using MentorProjectWebApp.Services.MentorSkillServices;
using MentorProjectWebApp.Services.MentorSocialMediaServices;
using MentorProjectWebApp.Services.MentorStatisticServices;
using MentorProjectWebApp.Services.MessageServices;
using MentorProjectWebApp.Services.ServiceServices;
using MentorProjectWebApp.Services.SkillServices;
using MentorProjectWebApp.Services.SocialMediaServices;
using MentorProjectWebApp.Services.SubDescriptionServices;
using MentorProjectWebApp.Services.SubsectionServices;
using MentorProjectWebApp.Services.TagServices;
using MentorProjectWebApp.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc.Razor;

namespace MentorProjectWebApp.Configurations
{
    public static class Configuration
    {
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IAboutUsService, AboutUsService>();
            builder.Services.AddScoped<IArticleService, ArticleService>();
            builder.Services.AddScoped<IArticleCommentService, ArticleCommentService>();
            builder.Services.AddScoped<IArticleContentService, ArticleContentService>();
            builder.Services.AddScoped<IArticleDetailService, ArticleDetailService>();
            builder.Services.AddScoped<IArticleTagService, ArticleTagService>();
            builder.Services.AddScoped<ICarouselService, CarouselService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IEngagementService, EngagementService>();
            builder.Services.AddScoped<IFeatureService, FeatureService>();
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
            builder.Services.AddScoped<ISubDescriptionService, SubDescriptionService>();
            builder.Services.AddScoped<ISubsectionService, SubsectionService>();
            builder.Services.AddScoped<ITagService, TagService>();
            builder.Services.AddScoped<ITestimonialService, TestimonialService>();
        }

        public static IHostBuilder ConfigureAppWithHttpClient(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.ConfigureServices((hostContext, services) =>
                {
                    services.AddRazorPages();

                    services.AddScoped<HttpClientErrorHandler>();

                    services.AddHttpClient("CustomHttpClient")
                            .AddHttpMessageHandler<HttpClientErrorHandler>();

                });

                webBuilder.Configure(app =>
                {
                    app.UseRouting();
                    app.UseEndpoints(endpoints =>
                    {
                        endpoints.MapRazorPages();
                    });
                });
            });

            return hostBuilder;
        }
    }
}
