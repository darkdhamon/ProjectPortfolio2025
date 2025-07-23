using Microsoft.AspNetCore.Mvc;
using Model.Entity.Abstract;
using Model.Repositories;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public abstract class CrudController<T> : ControllerBase where T : AEntity
{
    private readonly IRepository<T> _repository;

    protected CrudController(IRepository<T> repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<T>>> GetAll()
    {
        var items = await _repository.GetAllAsync();
        return Ok(items);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<T>> GetById(int id)
    {
        var item = await _repository.GetByIdAsync(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<T>> Create(T item)
    {
        await _repository.AddAsync(item);
        return CreatedAtAction(nameof(GetById), new { id = item.ID }, item);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, T item)
    {
        var existing = await _repository.GetByIdAsync(id);
        if (existing is null) return NotFound();

        item.ID = id;
        await _repository.UpdateAsync(item);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _repository.GetByIdAsync(id);
        if (item is null) return NotFound();

        await _repository.DeleteAsync(id);
        return NoContent();
    }
}
