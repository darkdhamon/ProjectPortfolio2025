using Model.Entity.Abstract;

namespace Model.Entity;

public class Profile : AEntity
{
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public string Title { get; set; }
    public string SelfDescription { get; set; }
    public List<EmploymentRecord> EmploymentHistory { get; set; } = new();
    public List<EducationRecord> EducationHistory { get; set; } = new();
    public List<Certification> Certifications { get; set; } = new();
    public List<Project> PersonalProjects { get; set; } = new();
}
