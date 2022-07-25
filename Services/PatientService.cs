using HomeworkWebApi.Models;
using HomeworkWebApi.Dto;
using HomeworkWebApi.Repositories;
using HomeworkWebApi.UnitOfWork;

namespace HomeworkWebApi.Services;

public class PatientService : IPatientService
{
    private readonly IPatientRepository _patientRepository;
    private readonly IUnitOfWork _unitOfWork;

    public PatientService( IPatientRepository patientRepository, IUnitOfWork unitOfWork )
    {
        _patientRepository = patientRepository;
        _unitOfWork = unitOfWork;
    }

    public List<Patient> GetAll()
    {
				var patients = _patientRepository.GetAll();
        _unitOfWork.Commit();
        return patients;
    }

    public void UpdateNameById( int id, string name )
    {
        Patient? patient = _patientRepository.GetById( id );
        patient.UpdateName( name );
        _patientRepository.Update( patient );
        _unitOfWork.Commit();
    }

    public void UpdatePhonenumberById( int id, string phoneNumber )
    {
        Patient? patient = _patientRepository.GetById( id );
        if ( patient != null )
        {
            patient.UpdatePhoneNumber( phoneNumber );
            _patientRepository.Update( patient );
            _unitOfWork.Commit();
        }
    }

    public void DeleteById( int id )
    {
        Patient? patient = _patientRepository.GetById( id );
        if ( patient != null )
        {
            _patientRepository.Delete( patient );
            _unitOfWork.Commit();
        }
    }

    public void AddPatient( string name, DateTime birthDate, string phoneNumber )
    {
        _patientRepository.Add( name, birthDate, phoneNumber );
        _unitOfWork.Commit();
    }
}
