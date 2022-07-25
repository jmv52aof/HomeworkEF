using Microsoft.EntityFrameworkCore;
using HomeworkWebApi.UnitOfWork;
using HomeworkWebApi.Repositories;
using HomeworkWebApi.Infrastructure;
using HomeworkWebApi.Services;

var builder = WebApplication.CreateBuilder( args );

builder.Services.AddControllers();

builder.Services.AddDbContext<ClinicDbContext>( ctx =>
{
    try
    {
        const string connectionString = @"Server=debian;Database=clinic;User Id=sa;Password=a12345678A;";
        ctx.UseSqlServer(connectionString);
    }
    catch (Exception)
    {
		}
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IVoucherRepository, VoucherRepository>();
builder.Services.AddScoped<IVoucherService, VoucherService>();

builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IDoctorService, DoctorService>();

builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IPatientService, PatientService>();

var app = builder.Build();
app.MapControllers();
app.Run();
