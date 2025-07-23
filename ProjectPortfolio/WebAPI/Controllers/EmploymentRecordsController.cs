using Model.Entity;
using Model.Repositories;

namespace WebAPI.Controllers;

public class EmploymentRecordsController : CrudController<EmploymentRecord>
{
    public EmploymentRecordsController(IRepository<EmploymentRecord> repository) : base(repository)
    {
    }
}
