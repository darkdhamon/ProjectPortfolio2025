using Model.Entity.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Model.Entity;

[Index(nameof(Name), IsUnique = true)]
public class Skill : AEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
}
