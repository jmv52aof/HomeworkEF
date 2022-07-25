using System.Data;
using HomeworkWebApi.Models;
using HomeworkWebApi.Infrastructure;
namespace HomeworkWebApi.Repositories;

public class DoctorRepository : IDoctorRepository
{
    private readonly ClinicDbContext _dbContext;

    public DoctorRepository( ClinicDbContext dbContext )
    {
        _dbContext = dbContext;
    }

	public List<Doctor> GetAll()
	{
		return _dbContext.Doctor.ToList();
	}
}
