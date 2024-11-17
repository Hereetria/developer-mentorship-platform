using BussinessLayer.Repositories;
using DtoLayer.Dtos.TestimonialDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.TestimonialServices
{
    public interface ITestimonialManager : IGenericRepositoryBL<Testimonial, CreateTestimonialDto, UpdateTestimonialDto, ResultTestimonialDto, ResultTestimonialByIdDto, int>
    {
    }
}