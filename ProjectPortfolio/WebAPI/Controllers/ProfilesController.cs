using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Model.Repositories;

namespace WebAPI.Controllers;

public class ProfilesController : CrudController<Profile>
{
    private readonly IProfileRepository _profiles;

    public ProfilesController(IProfileRepository repository) : base(repository)
    {
        _profiles = repository;
    }

    [HttpGet("{id}/projects")]
    public async Task<ActionResult<IEnumerable<Project>>> GetAllProjects(int id)
    {
        var projects = await _profiles.GetAllProjectsAsync(id);
        return Ok(projects);
    }
}
