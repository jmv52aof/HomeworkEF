using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HomeworkWebApi.Models;

namespace HomeworkWebApi.Infrastructure.Configurations
{
    public class DoctorMap : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();

            builder.Property(x => x.Specialisation).HasMaxLength(255).IsRequired();

            builder.Property(x => x.YearsOfExperience);
        }
    }
}
