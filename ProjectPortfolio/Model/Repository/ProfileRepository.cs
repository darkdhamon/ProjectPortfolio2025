namespace Model.Repository;

using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entity;

public class ProfileRepository : EfRepository<Profile>, IProfileRepository
{
    private readonly PortfolioContext _context;

    public ProfileRepository(PortfolioContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Profile?> GetFullProfileAsync(int id)
    {
        return await _context.Profiles
            .Include(p => p.EmploymentHistory)
                .ThenInclude(e => e.Projects)
            .Include(p => p.EducationHistory)
            .Include(p => p.Certifications)
            .Include(p => p.PersonalProjects)
                .ThenInclude(pr => pr.Skills)
            .FirstOrDefaultAsync(p => p.ID == id);
    }
}
