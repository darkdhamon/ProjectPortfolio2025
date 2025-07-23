using Model.Entity.Abstract;

namespace Model.Entity;

public class Person : AEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Location { get; set; }
    public string ContactEmail { get; set; }
    public string Phone { get; set; }
    public List<Profile> Portfolios { get; set; } = new();
}
