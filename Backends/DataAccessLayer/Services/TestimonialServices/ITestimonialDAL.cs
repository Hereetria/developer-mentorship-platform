
using DtoLayer.Dtos.TestimonialDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.TestimonialServices
{

    public interface ITestimonialDAL : IGenericRepositoryDAL<Testimonial, CreateTestimonialDto, UpdateTestimonialDto, ResultTestimonialDto, ResultTestimonialByIdDto, int>

    {

    }
}