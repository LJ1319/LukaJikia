namespace ATM
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int AccountNumber { get; set; }

        public decimal DebitMoney { get; set; }
        public decimal CreditMoney { get; set; }

        private List<Transaction> _allTransactions = new List<Transaction>();

        public List<Transaction> AllTransactions
        {
            get { return _allTransactions; }
            set { _allTransactions = value; }
        }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string? ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
