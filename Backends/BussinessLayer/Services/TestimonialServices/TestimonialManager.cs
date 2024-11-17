using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.TestimonialDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.TestimonialServices
{
    public class TestimonialManager : GenericRepositoryBL<Testimonial, CreateTestimonialDto, UpdateTestimonialDto, ResultTestimonialDto, ResultTestimonialByIdDto, int>, ITestimonialManager
    {
        public TestimonialManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}