using Belcorp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Belcorp.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(a => a.CategoryName).IsRequired().HasMaxLength(60);
            builder.Property(a => a.CategoryDescription).IsRequired().HasMaxLength(250);
        }
    }
}
