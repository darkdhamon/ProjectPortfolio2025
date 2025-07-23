using Microsoft.AspNetCore.Mvc;
using Model.Entity.Abstract;
using WebAPI.Data;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public abstract class CrudController<T> : ControllerBase where T : AEntity
{
    protected abstract List<T> Items { get; }

    [HttpGet]
    public ActionResult<IEnumerable<T>> GetAll()
    {
        return Ok(Items);
    }

    [HttpGet("{id}")]
    public ActionResult<T> GetById(int id)
    {
        var item = Items.FirstOrDefault(e => e.ID == id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public ActionResult<T> Create(T item)
    {
        item.ID = InMemoryData.GetNextId(Items);
        Items.Add(item);
        return CreatedAtAction(nameof(GetById), new { id = item.ID }, item);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, T item)
    {
        var existing = Items.FirstOrDefault(e => e.ID == id);
        if (existing is null) return NotFound();

        var index = Items.IndexOf(existing);
        item.ID = id;
        Items[index] = item;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var item = Items.FirstOrDefault(e => e.ID == id);
        if (item is null) return NotFound();

        Items.Remove(item);
        return NoContent();
    }
}
