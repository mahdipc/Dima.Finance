
// Core - Domain Layer
using Dima.Finance.Domain.Accounts;
using Dima.Finance.Domain.Common;
using Dima.Finance.Domain.Loans;


namespace Dima.Finance.Domain.Customers
{
    public class Customer : AggregateRoot
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public Address Address { get; private set; }
        public CustomerStatus Status { get; private set; }
        public virtual ICollection<Account> Accounts { get; private set; }
        public virtual ICollection<LoanApplication> LoanApplications { get; private set; }

        // Rest of the Customer implementation...
    }
}
