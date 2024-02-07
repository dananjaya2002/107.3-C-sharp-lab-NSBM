﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class BankAccount
    {
        public int AccoutNumber { get; set; }
        public int Balance { get; set;}

        public BankAccount(int accoutNumber, int balance)
        {
            AccoutNumber = accoutNumber;
            Balance = balance;
        }

        public void Deposit(int amount)
        {
            Balance = Balance + amount;
        }
    }
    internal class Program
    {
       public static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(0,0);

            Console.WriteLine("Enter you Account number:");
            account1.AccoutNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Amount you wish to deposit:");
            int amount = int.Parse(Console.ReadLine());
            account1.Deposit(amount);

            Console.WriteLine($"In {account1.AccoutNumber} account's updated balance is {account1.Balance}.");
            Console.ReadLine();
        }

        

    }
}
