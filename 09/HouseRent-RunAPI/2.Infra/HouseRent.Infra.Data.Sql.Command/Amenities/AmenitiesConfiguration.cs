using HouseRent.Core.Domain.Amenities.Entities;
using HouseRent.Core.Domain.Shared.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRent.Infra.Data.Sql.Command.Amenities;
internal class AmenitiesConfiguration : IEntityTypeConfiguration<Amenity>
{
    public void Configure(EntityTypeBuilder<Amenity> builder)
    {
        builder.ToTable("Amenities");
        builder.Property(c => c.Id).ValueGeneratedNever();
        builder.HasKey(x => x.Id);
        builder.Property(amenity => amenity.Title)
          .HasMaxLength(200)
          .HasConversion(title => title.Value, value => new Title(value));
        builder.Property(amenity => amenity.Price)
           .HasConversion(price => price.Amount, value => new Money(value));
    }
}
