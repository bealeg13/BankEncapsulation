namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Get Balance");
                Console.WriteLine("3. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the amount to deposit: $");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            myAccount.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Error. Please enter a valid number.");
                        }
                        break;

                    case 2:
                        Console.WriteLine($"Your balance amount: ${myAccount.GetBalance()}");
                        break;

                    case 3:
                        Console.WriteLine("Exiting the application.");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
