using Dima.Finance.Domain.Common;
using Dima.Finance.Domain.Customers;



namespace Dima.Finance.Domain.Loans
{
    public class LoanApplication : AggregateRoot
    {
        public Guid CustomerId { get; private set; }
        public decimal Amount { get; private set; }
        public int Term { get; private set; }
        public LoanType Type { get; private set; }
        public LoanStatus Status { get; private set; }
        public decimal InterestRate { get; private set; }
        public virtual Customer Customer { get; private set; }

        // Rest of the LoanApplication implementation...
    }
}
