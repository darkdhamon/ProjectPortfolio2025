using Model.Entity;

namespace Model.Repositories;

public interface IProfileRepository : IRepository<Profile>
{
    Task<IEnumerable<Project>> GetAllProjectsAsync(int profileId);
}
