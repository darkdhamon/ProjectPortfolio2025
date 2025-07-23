using Model.Entity.Abstract;

namespace Model.Entity;

public class Profile : AEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public string Location { get; set; }
    public string ContactEmail { get; set; }
    public string Phone { get; set; }
    public string SelfDescription { get; set; }
    public List<EmploymentRecord> EmploymentHistory { get; set; } = new();
    public List<EducationRecord> EducationHistory { get; set; } = new();
    public List<Certification> Certifications { get; set; } = new();
    public List<Project> PersonalProjects { get; set; } = new();

    public IEnumerable<Project> AllProjects
    {
        get
        {
            return PersonalProjects.Concat(GetProjectsFromEmployment(EmploymentHistory));
        }
    }

    private static IEnumerable<Project> GetProjectsFromEmployment(IEnumerable<EmploymentRecord> records)
    {
        foreach (var record in records)
        {
            foreach (var project in record.Projects)
                yield return project;

            if (record.Clients != null)
            {
                foreach (var clientProject in GetProjectsFromEmployment(record.Clients))
                    yield return clientProject;
            }
        }
    }
}
