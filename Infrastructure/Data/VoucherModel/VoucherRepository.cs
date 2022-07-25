using System.Data;
using HomeworkWebApi.Models;
using HomeworkWebApi.Infrastructure;

namespace HomeworkWebApi.Repositories
{
    public class VoucherRepository : IVoucherRepository
    {
        private readonly ClinicDbContext _dbContext;

        public VoucherRepository( ClinicDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        public List<Voucher> GetAll()
        {
            return _dbContext.Voucher.ToList();
        }

        public Voucher? GetById( int id )
        {
            return _dbContext.Voucher.FirstOrDefault(x => x.Id == id);
        }

        public void Delete( Voucher voucher )
        {
            _dbContext.Voucher.Remove( voucher );
        }

        public void Add( DateTime receptionTime, int doctorId, int patientId )
        {
            var voucher = new Voucher( 0, receptionTime, doctorId, patientId );
            _dbContext.Voucher.Add( voucher );
        }
    }
}
