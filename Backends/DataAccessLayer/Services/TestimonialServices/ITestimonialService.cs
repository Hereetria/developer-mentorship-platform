
using DtoLayer.Dtos.TestimonialDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.TestimonialServices
{
    
    public interface ITestimonialService : IGenericRepository<CreateTestimonialDto, UpdateTestimonialDto, ResultTestimonialDto, ResultTestimonialByIdDto, int>

    {

    }
}