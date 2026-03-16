using System;
using System.Collections.Generic;
using System.Text;

namespace BMSwithOOPS
{
    public class Account
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public Account(int id, string name,  int balance)
        {
            Id = id; 
            Name = name;
            Balance = balance;
        }

        // ENCAPSULATION
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount} successfully. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount} successfully. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Account ID: {Id}, Name: {Name}, Balance: {Balance}");
        }
    }
}
