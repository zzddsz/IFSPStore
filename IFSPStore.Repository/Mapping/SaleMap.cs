using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.SaleDate)
                .IsRequired();
            builder.Property(prop => prop.SaleTotal)
                .IsRequired();
            builder.HasOne(prop => prop.Salesman)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(prop => prop.Customer)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(prop => prop.SaleItens)
                .WithOne(prop => prop.Sale)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
    public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("SaleItems");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Quantity);
            builder.Property(prop => prop.UnitPrice);
            builder.Property(prop => prop.TotalPrice);
            builder.HasOne(prop => prop.Sale)
                .WithMany(prop => prop.SaleItens)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(prop => prop.Product)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}