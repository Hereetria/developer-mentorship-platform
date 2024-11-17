

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.TestimonialDtos;
using DataAccessLayer.Services.TestimonialServices;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.TestimonialServices
{

    public class TestimonialDAL : GenericRepositoryDAL<Testimonial, CreateTestimonialDto, UpdateTestimonialDto, ResultTestimonialDto, ResultTestimonialByIdDto, int>, ITestimonialDAL

    {

        public TestimonialDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}