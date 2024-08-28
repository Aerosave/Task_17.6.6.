using  Task_17.TypesAccount;




namespace Task_17
{
    public class Program
    {
        public static void Main()
        {
            Account ordinaryAccount = new Account
            {
                AccountType = new OrdinaryAccount { Balance = 800 }
            };

            Account salaryAccount = new Account
            {
                AccountType = new SalaryAccount { Balance = 1500 }
            };

            Calculator.CalculateInterest(ordinaryAccount);
            Calculator.CalculateInterest(salaryAccount);

            Console.WriteLine($"Ordinary Account Interest: {ordinaryAccount.Interest}");
            Console.WriteLine($"Salary Account Interest: {salaryAccount.Interest}");
        }
    }
}