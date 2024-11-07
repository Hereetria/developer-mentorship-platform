

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.TestimonialDtos;
using DataAccessLayer.Services.TestimonialServices;
using DataAccessLayer.Repositories.Concrete;

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