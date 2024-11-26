using System.Transactions;



namespace Dima.Finance.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Account> Accounts { get; }
        DbSet<Customer> Customers { get; }
        DbSet<Transaction> Transactions { get; }
        DbSet<LoanApplication> LoanApplications { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
