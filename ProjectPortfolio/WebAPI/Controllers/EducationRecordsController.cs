using Model.Entity;
using WebAPI.Data;
using System.Collections.Generic;

namespace WebAPI.Controllers;

public class EducationRecordsController : CrudController<EducationRecord>
{
    protected override List<EducationRecord> Items => InMemoryData.EducationRecords;
}
