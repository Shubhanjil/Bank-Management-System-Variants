namespace BMSwithOOPS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Account> accounts = new Dictionary<int, Account>();
            Bank bank = new Bank();
            int nextId = 10001;
            Console.WriteLine("***Welcome to Bank Management System***\n");
            Console.WriteLine("What do you want to do:");
            Console.WriteLine("1. Create account");
            Console.WriteLine("2. Show account information");
            Console.WriteLine("3. Deposit to account");
            Console.WriteLine("4. Withdraw from account");
            Console.WriteLine("5. Show all accounts with ids");
            Console.WriteLine("6. Clear screen");
            Console.WriteLine("7. Exit");

            bool looping = true;
            while (looping == true)
            {
                Console.Write("\nEnter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice - 1)
                {
                    case 0:
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Initial Balance: ");
                        int balance = int.Parse(Console.ReadLine());
                        int id = nextId;
                        bank.CreateAccount(id, name, balance);
                        nextId += 1;
                        break;

                    case 1:
                        Console.Write("Enter Account ID: ");
                        int showId = int.Parse(Console.ReadLine());
                        bank.ShowAccount(showId);
                        break;
                    case 2:
                        Console.Write("Enter Account ID: ");
                        int depId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Amount to Deposit: ");
                        int depAmount = int.Parse(Console.ReadLine());
                        bank.Deposit(depId, depAmount);
                        break;
                    case 3:
                        Console.Write("Enter Account ID: ");
                        int wId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Amount to Withdraw: ");
                        int wAmount = int.Parse(Console.ReadLine());
                        bank.Withdraw(wId, wAmount);
                        break;
                    case 4:
                        bank.ShowAllAccounts();
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    case 6:
                        looping = false;
                        Console.WriteLine("Exiting the Application...");
                        break;
                    default:

                        break;
                }
            }
        }
    }
}
