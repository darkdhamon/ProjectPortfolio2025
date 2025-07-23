using Model.Entity.Abstract;

namespace Model.Entity;

public class Project : AEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Skill> Skills { get; set; } = new();
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}
