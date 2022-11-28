namespace ATM
{
    internal class DebitIban
    {
        public User User { get; set; }

        public decimal DebitMoney
        {
            get
            {
                decimal debit = 0;
                foreach (var transaction in User.AllTransactions)
                {
                    if (transaction.Amount < 0)
                    {
                        debit += transaction.Amount;
                    }
                }
                
                return debit;
            }
        }
    }
}
