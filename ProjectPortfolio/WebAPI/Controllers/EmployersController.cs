using Model.Entity;
using Model.Repositories;

namespace WebAPI.Controllers;

public class EmployersController : CrudController<Employer>
{
    public EmployersController(IRepository<Employer> repository) : base(repository)
    {
    }
}
