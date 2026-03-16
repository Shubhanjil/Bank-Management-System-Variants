using System;
using System.Collections.Generic;
using System.Text;

namespace BMSwithOOPS
{
    public class Bank
    {
        private Dictionary<int, Account> accounts = new Dictionary<int, Account>();
        // ABSTRACTION
        public void CreateAccount(int id, string name, int initialBalance)
        {
            if (!accounts.ContainsKey(id))
            {
                accounts[id] = new Account(id, name, initialBalance);
                Console.WriteLine("Account created successfully!");
            }
            else
            {
                Console.WriteLine("Account ID already exists.");
            }   
        }
        public void ShowAccount(int id)
        {
            if (accounts.ContainsKey(id))
            {
                accounts[id].ShowInfo();
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
        public void Deposit(int id, int amount)
        {
            if (accounts.ContainsKey(id))
            {
                accounts[id].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
        public void Withdraw(int id, int amount)
        {
            if (accounts.ContainsKey(id))
            {
                accounts[id].Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
        public void ShowAllAccounts()
        {
            foreach (var kvp in accounts)
            {
                kvp.Value.ShowInfo();
            }
        }

    }
}
