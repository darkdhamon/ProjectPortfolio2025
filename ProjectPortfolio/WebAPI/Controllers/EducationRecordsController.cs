using Model.Entity;
using Model.Repositories;

namespace WebAPI.Controllers;

public class EducationRecordsController : CrudController<EducationRecord>
{
    public EducationRecordsController(IRepository<EducationRecord> repository) : base(repository)
    {
    }
}
