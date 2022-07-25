using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HomeworkWebApi.Models;

namespace HomeworkWebApi.Infrastructure.Configurations
{
    public class VoucherMap : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.ReceptionTime);

            builder.Property(x => x.DoctorId);

            builder.Property(x => x.PatientId);
        }
    }
}
