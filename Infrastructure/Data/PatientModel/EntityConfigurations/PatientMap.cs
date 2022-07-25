using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HomeworkWebApi.Models;

namespace HomeworkWebApi.Infrastructure.Configurations
{
    public class PatientMap : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();

            builder.Property(x => x.BirthDate);

            builder.Property(x => x.PhoneNumber).HasMaxLength(255).IsRequired();
        }
    }
}
