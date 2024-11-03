

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.TestimonialDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.TestimonialServices;

namespace DataAccessLayer.Services.TestimonialServices
{
    
    public class TestimonialService : GenericRepository<Testimonial, CreateTestimonialDto, UpdateTestimonialDto, ResultTestimonialDto, ResultTestimonialByIdDto, int>, ITestimonialService

    {

        public TestimonialService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}