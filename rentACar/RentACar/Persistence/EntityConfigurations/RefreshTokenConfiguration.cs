using Core.Security.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;
public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder.ToTable("RefreshTokens").HasKey(r => r.Id);
        builder.Property(r => r.Id).HasColumnName("Id");
        builder.Property(r => r.UserId).HasColumnName("UserId");
        builder.Property(r => r.Token).HasColumnName("Token");
        builder.Property(r => r.Expires).HasColumnName("Expires");
        builder.Property(r => r.Created).HasColumnName("Created");
        builder.Property(r => r.CreatedByIp).HasColumnName("CreatedByIp");
        builder.Property(r => r.Revoked).HasColumnName("Revoked");
        builder.Property(r => r.RevokedByIp).HasColumnName("RevokedByIp");
        builder.Property(r => r.ReplacedByToken).HasColumnName("ReplacedByToken");
        builder.Property(r => r.ReasonRevoked).HasColumnName("ReasonRevoked");
        builder.Property(r => r.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(r => r.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(r => r.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(r => !r.DeletedDate.HasValue);

        builder.HasOne(r => r.User);
    }
}