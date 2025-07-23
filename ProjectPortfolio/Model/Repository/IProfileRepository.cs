namespace Model.Repository;

using Model.Entity;

public interface IProfileRepository : IRepository<Profile>
{
    Task<Profile?> GetFullProfileAsync(int id);
}
