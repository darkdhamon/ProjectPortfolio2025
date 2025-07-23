using Model.Entity.Abstract;

namespace Model.Entity;

public class EmploymentRecord : AEntity
{
    public int EmployerId { get; set; }
    public Employer Employer { get; set; }
    public string Position { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public string Description { get; set; }
    public List<Project> Projects { get; set; } = new();

    public List<Employer> Clients { get; set; } = new();
}
