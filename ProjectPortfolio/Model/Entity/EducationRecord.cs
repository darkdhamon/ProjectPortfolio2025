using Model.Entity.Abstract;

namespace Model.Entity;

public class EducationRecord : AEntity
{
    public string Institution { get; set; }
    public string Degree { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public string Description { get; set; }
}
