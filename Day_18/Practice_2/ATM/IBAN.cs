using System.Transactions;

namespace ATM
{
    internal class IBAN
    {
        public string Number { get; }
        public User Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var transaction in allTransactions)
                {
                    balance += transaction.Amount;
                }

                return balance;
            }
        }

        private static int accountNumberSeed = 123456789;

        public IBAN(User owner, int initialBalance)
        {
            Owner = owner;

            Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            owner.AccountNumber = accountNumberSeed;

            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new NotSufficientFundsException("Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);

            Owner.AllTransactions = allTransactions;
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new NotSufficientFundsException("Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new NotSufficientFundsException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);

            Owner.AllTransactions = allTransactions;
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var transaction in allTransactions)
            {
                balance += transaction.Amount;
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{balance}\t{transaction.Notes}");
            }

            return report.ToString();
        }
    }
}
