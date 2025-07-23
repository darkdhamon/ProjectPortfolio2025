using Model.Entity;
using WebAPI.Data;
using System.Collections.Generic;

namespace WebAPI.Controllers;

public class ProjectsController : CrudController<Project>
{
    protected override List<Project> Items => InMemoryData.Projects;
}
