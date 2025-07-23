using Model.Entity;
using Model.Repositories;

namespace WebAPI.Controllers;

public class ProjectsController : CrudController<Project>
{
    public ProjectsController(IRepository<Project> repository) : base(repository)
    {
    }
}
