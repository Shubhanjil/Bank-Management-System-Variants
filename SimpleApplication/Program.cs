namespace BankMgmtSys
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, Account> accounts = new Dictionary<int, Account>();
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
                        Console.Write("Enter Account Holder Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Initial Deposit: ");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        var acc = new Account { Id = nextId++, Name = name, Balance = deposit };
                        accounts[acc.Id] = acc;
                        Console.WriteLine($"Account created successfully!\nAccount Holder: {acc.Name}\nAccount Number: {acc.Id}\nBalance: {acc.Balance}");
                        break;
                    case 1:
                        Console.Write("Enter Account Number: ");
                        int checkId = int.Parse(Console.ReadLine());
                        if (accounts.ContainsKey(checkId))
                        {
                            var a = accounts[checkId];
                            Console.WriteLine($"Account Number: {a.Id}\nAccount Holder: {a.Name}\nBalance: {a.Balance}");
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("***DEPOSIT***");
                        Console.Write("Enter Account Number: ");
                        int depoId = int.Parse(Console.ReadLine());
                        if (accounts.ContainsKey(depoId))
                        {
                            var a = accounts[depoId];
                            Console.Write("Enter Amount: ");
                            int addAmt = Convert.ToInt32(Console.ReadLine());
                            try {
                                a.Balance += addAmt;
                                Console.WriteLine("Amount Deposited Successfully!");
                            } catch {
                                Console.WriteLine("Amount Deposited Failed!");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("***WITHDRAW***");
                        Console.Write("Enter Account Number: ");
                        int withdrawId = int.Parse(Console.ReadLine());
                        if (accounts.ContainsKey(withdrawId))
                        {
                            var a = accounts[withdrawId];
                            Console.Write("Enter Amount: ");
                            int withdrawAmt = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                a.Balance -= withdrawAmt;
                                Console.WriteLine("Amount Withdrawn Successfully!");
                            }
                            catch
                            {
                                Console.WriteLine("Amount Withdrawn Failed!");
                            }
                        }
                        break;
                    case 4:
                        foreach (Account account in accounts.Values) {
                            Console.WriteLine($"Account Number: {account.Id}\tAccount Holder: {account.Name}");
                        }
                        break;
                    case 5:
                        try
                        {
                            Console.Clear();
                            looping = false;
                        } catch
                        {
                            Console.WriteLine("Clearing the Screen Failed");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Exiting the Application...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }
        }
    }
}
