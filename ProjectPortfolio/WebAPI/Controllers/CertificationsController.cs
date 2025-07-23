using Model.Entity;
using Model.Repositories;

namespace WebAPI.Controllers;

public class CertificationsController : CrudController<Certification>
{
    public CertificationsController(IRepository<Certification> repository) : base(repository)
    {
    }
}
