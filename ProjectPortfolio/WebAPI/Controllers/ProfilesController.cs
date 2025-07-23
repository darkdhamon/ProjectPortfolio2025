using Model.Entity;
using Model.Repositories;

namespace WebAPI.Controllers;

public class ProfilesController : CrudController<Profile>
{
    public ProfilesController(IRepository<Profile> repository) : base(repository)
    {
    }
}
