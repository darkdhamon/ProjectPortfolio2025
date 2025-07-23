using Model.Entity;
using WebAPI.Data;
using System.Collections.Generic;

namespace WebAPI.Controllers;

public class EmploymentRecordsController : CrudController<EmploymentRecord>
{
    protected override List<EmploymentRecord> Items => InMemoryData.EmploymentRecords;
}
