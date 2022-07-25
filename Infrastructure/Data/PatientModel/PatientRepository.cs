using System.Data;
using HomeworkWebApi.Models;
using HomeworkWebApi.Infrastructure;

namespace HomeworkWebApi.Repositories;

public class PatientRepository : IPatientRepository
{
    private readonly ClinicDbContext _dbContext;

    public PatientRepository( ClinicDbContext dbContext )
    {
        _dbContext = dbContext;
    }

	public List<Patient> GetAll()
	{
		return _dbContext.Patient.ToList();
	}

	public Patient? GetById( int id )
	{
		return _dbContext.Patient.FirstOrDefault(x => x.Id == id);
	}

	public void Delete( Patient patient )
	{
		_dbContext.Patient.Remove(patient);
	}

	public void Update( Patient patient )
	{
		_dbContext.Patient.Update(patient);

	}

	public void Add( string name, DateTime birthDate, string phoneNumber )
	{
		var patient = new Patient( 0, name, birthDate, phoneNumber );
		_dbContext.Patient.Add( patient );
	}
}
