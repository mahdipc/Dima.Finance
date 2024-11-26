
// Core - Domain Layer
using Dima.Finance.Domain.Common;
using Dima.Finance.Domain.Customers;
using System.Transactions;

namespace Dima.Finance.Domain.Accounts
{
    public class Account : AggregateRoot
    {
        public string Number { get; private set; }
        public decimal Balance { get; private set; }
        public string Currency { get; private set; }
        public AccountStatus Status { get; private set; }
        public AccountType Type { get; private set; }
        public Guid CustomerId { get; private set; }
        public virtual Customer Customer { get; private set; }
        public virtual ICollection<Transaction> Transactions { get; private set; }

        // Rest of the Account implementation...
    }
}
