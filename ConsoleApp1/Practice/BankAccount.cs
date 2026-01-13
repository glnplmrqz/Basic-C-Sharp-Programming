using Microsoft.VisualBasic.FileIO;
using System;

namespace PracticeCSharp {

    /*
     * Creating a Banking System
     */

    class Bank {

        int accountNumber { get; set; } // Encapsulated
        string accountHolder { get; set; } // Encapsulated
        double balance = 0; // Initialize balance to zero

        // User Details
        public void enterDetails() {

            Console.Write("\n Enter Account Number: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter Account Holder Name: ");
            accountHolder = Console.ReadLine();

            do {
                Console.WriteLine("\n --- Banking Menu ---");
                Console.WriteLine(" 1. Deposit ");
                Console.WriteLine(" 2. Withdraw ");
                Console.WriteLine(" 3. Check Balance ");
                Console.WriteLine(" 4. Exit ");

                Console.Write("\n Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) {
                    case 1:
                        deposit();
                        break;
                    case 2:
                        withdraw();
                        break;
                    case 3:
                        checkBalance();
                        break;
                    case 4:
                        Console.WriteLine("\n Thank you for using the Banking System!");
                        return;
                    default:
                        Console.WriteLine("\n Invalid Choices... Try Again!");
                        break;
                }

            } while (true);

        }


        // Deposit
        public void deposit() {

            Console.Write("\n Enter amount to deposit: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Deposit Successful!");

            balance += amount; // To update your current balance
            Console.WriteLine($" Current Balance: {balance} Pesos.");

        }

        // Withdraw
        public void withdraw() {

            Console.Write("\n Enter amount to withdraw: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount <= balance) {

                Console.WriteLine(" Withdrawal Successful! ");

                balance -= amount; // To update current balance
                Console.WriteLine($" Current Balance: {balance} Pesos.");
            }

        }

        public void checkBalance() {
            Console.WriteLine($" Your Current Balance is: {balance}");
        }

    }

    class BankAccount {

        static void Main(string[] args) {

            Bank bankAccount = new Bank();
            bankAccount.enterDetails();
        }
    }
}