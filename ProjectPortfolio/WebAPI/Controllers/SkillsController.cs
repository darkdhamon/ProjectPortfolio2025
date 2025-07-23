using Model.Entity;
using WebAPI.Data;
using System.Collections.Generic;

namespace WebAPI.Controllers;

public class SkillsController : CrudController<Skill>
{
    protected override List<Skill> Items => InMemoryData.Skills;
}
