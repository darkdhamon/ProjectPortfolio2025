using Model.Entity;
using WebAPI.Data;

namespace WebAPI.Controllers;

public class ProfilesController : CrudController<Profile>
{
    protected override List<Profile> Items => InMemoryData.Profiles;
}
