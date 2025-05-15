using Core.Persistence.Repositories;
using Domain.Enums;

namespace Domain.Entities;

public class Car : Entity<Guid>
{
    public Guid modelId { get; set; }
    public short modelYear { get; set; }
    public short minFindexSkor { get; set; }
    public string kilometer { get; set; }
    public string plate { get; set; }
    public CarState carState { get; set; }

    public virtual Model? Model { get; set; }

    public Car()
    {

    }

    public Car(Guid id, Guid modelId, short modelYear, short minFindexSkor, string kilometer, string plate, CarState carState) : this()
    {
        this.Id = id;
        this.modelId = modelId;
        this.modelYear = modelYear;
        this.minFindexSkor = minFindexSkor;
        this.kilometer = kilometer;
        this.plate = plate;
        this.carState = carState;
    } 
}


