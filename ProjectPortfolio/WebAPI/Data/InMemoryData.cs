using Model.Entity;
using Model.Entity.Abstract;

namespace WebAPI.Data;

public static class InMemoryData
{
    public static List<Profile> Profiles { get; } = new();
    public static List<Project> Projects { get; } = new();
    public static List<Skill> Skills { get; } = new();
    public static List<Certification> Certifications { get; } = new();
    public static List<EducationRecord> EducationRecords { get; } = new();
    public static List<EmploymentRecord> EmploymentRecords { get; } = new();

    public static int GetNextId<T>(List<T> items) where T : AEntity
    {
        if (items.Count == 0)
            return 1;
        return items.Max(i => i.ID) + 1;
    }
}
