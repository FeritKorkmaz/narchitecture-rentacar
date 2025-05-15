using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ModelConfigurations : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.ToTable("Models").HasKey(b => b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.name).HasColumnName("name").IsRequired();
        builder.Property(b => b.brandId).HasColumnName("brandId").IsRequired();
        builder.Property(b => b.fuelId).HasColumnName("fuelId").IsRequired();
        builder.Property(b => b.transmissionId).HasColumnName("transmissionId").IsRequired();
        builder.Property(b => b.dailyPrice).HasColumnName("dailyPrice").IsRequired();
        builder.Property(b => b.imageUrl).HasColumnName("imageUrl").IsRequired();
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.HasIndex(indexExpression: b => b.name, name: "UK_Models_Name").IsUnique();
        builder.HasOne(b => b.Brand);
        builder.HasOne(b => b.Fuel);
        builder.HasOne(b => b.Transmission);
        builder.HasMany(b => b.Cars);

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
