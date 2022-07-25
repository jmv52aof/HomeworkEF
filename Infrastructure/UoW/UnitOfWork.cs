using HomeworkWebApi.Infrastructure;

namespace HomeworkWebApi.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClinicDbContext _dbContext;

        public UnitOfWork(ClinicDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}