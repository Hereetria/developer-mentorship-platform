namespace MentorProjectWebApp.Services.SubsectionServices
{
    using MentorProjectWebApp.Dtos.SubsectionDtos;
    using MentorProjectWebApp.Repositories;

    public interface ISubsectionService : IGenericRepository<CreateSubsectionDto, UpdateSubsectionDto, ResultSubsectionDto, ResultSubsectionByIdDto, int>
    {
    }

}
