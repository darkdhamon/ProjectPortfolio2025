using Model.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Project : AEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Skill> Skills { get; set; } = new();
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }

    public class EmploymentRecord:AEntity
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string Description { get; set; }
        public List<Project> Projects { get; set; } = new();

        public List<EmploymentRecord> Clients { get; set; } = new();
    }

    [Index(nameof(Name), IsUnique = true)]
    public class Skill : AEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
