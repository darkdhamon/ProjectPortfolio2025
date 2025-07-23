using Model.Entity;
using Model.Repositories;

namespace WebAPI.Controllers;

public class SkillsController : CrudController<Skill>
{
    public SkillsController(IRepository<Skill> repository) : base(repository)
    {
    }
}
