namespace ATM
{
    internal class CreditIban
    {
        public User User { get; set; }

        public decimal CreditMoney
        {
            get
            {
                decimal credit = 0;
                foreach (var transaction in User.AllTransactions)
                {
                    if (transaction.Amount > 0)
                    {
                        credit += transaction.Amount;
                    }
                }

                return credit;
            }
        }
    }
}
