using HomeworkWebApi.Models;
using HomeworkWebApi.Dto;
using HomeworkWebApi.Repositories;
using HomeworkWebApi.UnitOfWork;

namespace HomeworkWebApi.Services;

public class VoucherService : IVoucherService
{
    private readonly IVoucherRepository _voucherRepository;
    private readonly IUnitOfWork _unitOfWork;

    public VoucherService( IVoucherRepository voucherRepository, IUnitOfWork unitOfWork )
    {
        _voucherRepository = voucherRepository;
        _unitOfWork = unitOfWork;
    }

    public List<Voucher> GetVouchers()
    {
        var result = _voucherRepository.GetAll().ToList();
        _unitOfWork.Commit();
        return result;
    }

    public void Delete( int voucherId )
    {
        Voucher? voucher = _voucherRepository.GetById( voucherId );
        if ( voucher == null )
        {
            throw new Exception( $"{nameof( voucher )} not found, #Id - {voucherId}" );
        }
        _voucherRepository.Delete( voucher );
        _unitOfWork.Commit();
    }

    public void Add( DateTime receptionTime, int doctorId, int patientId )
    {
        _voucherRepository.Add( receptionTime, doctorId, patientId );
        _unitOfWork.Commit();
    }
}
