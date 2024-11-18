

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EntityLayer.Entities;

namespace DataAccessLayer.Contexts
{
    
    public class Context : DbContext

    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = @"Server=DESKTOP-A7AFDHF\SQLEXPRESS;Initial Catalog=MentorProject;Integrated Security=true;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<AboutUs> AboutUses { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
        public DbSet<ArticleContent> ArticleContents { get; set; }
        public DbSet<ArticleDetail> ArticleDetails { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Engagement> Engagements { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<MentorContent> MentorContents { get; set; }
        public DbSet<MentorSkill> MentorSkills { get; set; }
        public DbSet<MentorSocialMedia> MentorSocialMedias { get; set; }
        public DbSet<MentorStatistic> MentorStatistics { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<SubDescription> SubDescriptions { get; set; }
        public DbSet<Subsection> Subsections { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}