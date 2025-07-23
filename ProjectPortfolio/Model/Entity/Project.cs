using Model.Entity.Abstract;
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
        public List<Skill> Skills { get; set; }
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
        public List<Project> Projects { get; set; }

        public List<EmploymentRecord> Clients { get; set; }
    }

    public class Skill : AEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
