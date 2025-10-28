﻿using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

            builder.Property(p => p.Login).IsRequired().HasMaxLength(50);

            builder.Property(p => p.Email).IsRequired().HasMaxLength(100);

            builder.Property(p => p.Password).IsRequired().HasMaxLength(100);

            builder.Property(p => p.RegisterDate);

            builder.Property(p => p.LoginDate);

            builder.Property(p => p.IsActive);
        }
    }
}