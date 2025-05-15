using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Model : Entity<Guid>
{
    public Guid brandId { get; set; }
    public Guid fuelId { get; set; }
    public Guid transmissionId { get; set; }
    public string name { get; set; }
    public decimal dailyPrice { get; set; }
    public string imageUrl { get; set; }

    public virtual Brand? Brand { get; set; }
    public virtual Fuel? Fuel { get; set; }
    public virtual Transmission? Transmission { get; set; }
    public virtual ICollection<Car>? Cars { get; set; }

    public Model()
    {
        Cars = new HashSet<Car>();
    }
    public Model(Guid id, Guid brandId, Guid fuelId, Guid transmissionId, string name, decimal dailyPrice, string imageUrl) : this()
    {
        Id = id;
        this.brandId = brandId;
        this.fuelId = fuelId;
        this.transmissionId = transmissionId;
        this.name = name;
        this.dailyPrice = dailyPrice;
        this.imageUrl = imageUrl;
    }
}


