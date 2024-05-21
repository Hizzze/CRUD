using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonCrud.Core.Models;

namespace PersonCrud.DataAccess.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.FirstName)
            .HasMaxLength(25)
            .IsRequired();
        builder.Property(p => p.LastName)
            .HasMaxLength(25)
            .IsRequired();
        builder.Property(p => p.Age)
            .IsRequired();
    }
}