using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .IsRequired();
            builder.Property(prop => prop.Login)
                .IsRequired();
            builder.Property(prop => prop.Password)
                .IsRequired();
            builder.Property(prop => prop.Email)
                .IsRequired();
            builder.Property(prop => prop.RegisterDate)
                .IsRequired();
            builder.Property(prop => prop.LoginDate)
                .IsRequired();
            builder.Property(prop => prop.IsActive);
        }
    }
}