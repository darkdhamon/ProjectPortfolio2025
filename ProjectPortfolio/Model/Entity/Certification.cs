using Model.Entity.Abstract;

namespace Model.Entity;

public class Certification : AEntity
{
    public string Name { get; set; }
    public string Issuer { get; set; }
    public DateOnly DateAwarded { get; set; }
}
