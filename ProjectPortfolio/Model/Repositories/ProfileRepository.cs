using Microsoft.EntityFrameworkCore;
using Model.Entity;

namespace Model.Repositories;

public class ProfileRepository : Repository<Profile>, IProfileRepository
{
    public ProfileRepository(PortfolioContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Project>> GetAllProjectsAsync(int profileId)
    {
        var profile = await _context.Profiles
            .Include(p => p.PersonalProjects)
            .Include(p => p.EmploymentHistory)
                .ThenInclude(e => e.Projects)
            .Include(p => p.EmploymentHistory)
                .ThenInclude(e => e.Clients)
                    .ThenInclude(c => c.Projects)
            .FirstOrDefaultAsync(p => p.ID == profileId);

        if (profile is null) return Enumerable.Empty<Project>();

        return GetProjects(profile);
    }

    private static IEnumerable<Project> GetProjects(Profile profile)
    {
        return profile.PersonalProjects.Concat(GetProjectsFromEmployment(profile.EmploymentHistory));
    }

    private static IEnumerable<Project> GetProjectsFromEmployment(IEnumerable<EmploymentRecord> records)
    {
        foreach (var record in records)
        {
            foreach (var project in record.Projects)
                yield return project;

            if (record.Clients != null)
            {
                foreach (var clientProject in GetProjectsFromEmployment(record.Clients))
                    yield return clientProject;
            }
        }
    }
}
