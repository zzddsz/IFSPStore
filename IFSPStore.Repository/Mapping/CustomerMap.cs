using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class CostumerMap : IEntityTypeConfiguration<Costumer>
    {
        public void Configure(EntityTypeBuilder<Costumer> builder)
        {
            builder.ToTable("Costumer");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.Address)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.Document)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(prop => prop.District)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasOne(prop => prop.City)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}