using HomeworkWebApi.Models;
using HomeworkWebApi.Dto;
using HomeworkWebApi.Repositories;
using HomeworkWebApi.UnitOfWork;

namespace HomeworkWebApi.Services;

public class DoctorService : IDoctorService
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DoctorService( IDoctorRepository doctorRepository, IUnitOfWork unitOfWork )
    {
        _doctorRepository = doctorRepository;
			  _unitOfWork = unitOfWork;
    }

    public List<Doctor> GetAll()
    {

				var result = _doctorRepository.GetAll();
				_unitOfWork.Commit();
				return result;
    }
}
