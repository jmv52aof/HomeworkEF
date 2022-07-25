using Microsoft.EntityFrameworkCore;
using HomeworkWebApi.Models;
using HomeworkWebApi.Infrastructure.Configurations;

namespace HomeworkWebApi.Infrastructure
{
    public class ClinicDbContext : DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Voucher> Voucher { get; set; }


        public ClinicDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoctorMap());
            modelBuilder.ApplyConfiguration(new PatientMap());
            modelBuilder.ApplyConfiguration(new VoucherMap());
        }
    }
}
