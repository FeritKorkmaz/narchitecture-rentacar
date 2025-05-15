using Core.Persistence.Repositories;

namespace Domain.Entities;

public class  Transmission : Entity<Guid>
{
    public string name { get; set; }
    public virtual ICollection<Model> Models { get; set; }

    public Transmission()
    {
        Models = new HashSet<Model>();
    }
    public Transmission(Guid id, string name) : this()
    {
        this.Id = id;
        this.name = name;
    }
}


