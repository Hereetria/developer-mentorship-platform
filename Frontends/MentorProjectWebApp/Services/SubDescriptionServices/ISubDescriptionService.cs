using MentorProjectWebApp.Dtos.SubDescriptionDtos;
using MentorProjectWebApp.Repositories.Abstract;

namespace MentorProjectWebApp.Services.SubDescriptionServices
{
    public interface ISubDescriptionService : IGenericRepository<CreateSubDescriptionDto, UpdateSubDescriptionDto, ResultSubDescriptionDto, ResultSubDescriptionByIdDto, int>
    {
    }
}
