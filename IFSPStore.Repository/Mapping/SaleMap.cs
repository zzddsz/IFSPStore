using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.SaleDate);
            builder.Property(prop => prop.SaleTotal);

            builder.HasOne(prop => prop.Salesman)
                   .WithMany()
                   .HasForeignKey(prop => prop.UserId);

            builder.HasOne(prop => prop.Customer);

            builder.HasMany(prop => prop.SaleItens)
                   .WithOne(prop => prop.Sale)
                   .HasForeignKey(prop => prop.SaleId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("SaleItem");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Quantity);
            builder.Property(prop => prop.UnitPrice);
            builder.Property(prop => prop.TotalPrice);
            builder.HasOne(prop => prop.Product);
        }
    }
}