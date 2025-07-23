using Model.Entity;
using WebAPI.Data;
using System.Collections.Generic;

namespace WebAPI.Controllers;

public class CertificationsController : CrudController<Certification>
{
    protected override List<Certification> Items => InMemoryData.Certifications;
}
