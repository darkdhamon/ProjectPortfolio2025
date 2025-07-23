using Model.Entity.Abstract;

namespace Model.Entity;

public class EmploymentRecord : AEntity
{
    public string CompanyName { get; set; }
    public string Position { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public string Description { get; set; }
    public List<Project> Projects { get; set; } = new();

    public List<EmploymentRecord> Clients { get; set; } = new();
}
