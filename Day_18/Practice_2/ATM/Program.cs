namespace ATM
{
    internal class Program
    {
        static void Main()
        {
            User owner = new User("Luka", "Jikia");

            var account = new IBAN(owner, 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            //Console.WriteLine(account.Balance);

            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            //Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            //Console.WriteLine(owner.DebitMoney);
            //Console.WriteLine(owner.CreditMoney);

            // Custom Exception Usage1
            // Test that the initial balances must be positive.
            /*IBAN invalidAccount;
            try
            {
                invalidAccount = new IBAN(owner, -55);
            }
            catch (NotSufficientFundsException ex)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(ex.ToString());
                return;
            }*/

            // Custom Exception Usage2
            // Test for a negative balance.
            /*try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (NotSufficientFundsException ex)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(ex.ToString());
                return;
            }*/
        }
    }
}