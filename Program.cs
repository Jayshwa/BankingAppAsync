using System;

namespace BankingApp
// This namespace contains the classes and methods for the Wealth Bank application.
// It includes the main program, account management, and account holder classes.
// The classes are designed to manage account holders, their balances, and transactions.
// The application is designed to simulate a banking system where users can manage their accounts.
{
    public class Program
    // This class contains the Main method, which is the entry point of the application.
    // It serves as the starting point for the Wealth Bank application.
    {
        public static async Task Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Wealth Bank!");

            AccountHolderClass JohnsAccount = new AccountHolderClass("John Doe", 100);
            JohnsAccount.ShowBalance();
            // Creates an instance of the AccountHolderClass for John
            // Calls the ShowBalance method to display his initial balance

            AccountHolderClass ClarasAccount = new AccountHolderClass("Clara Doe", 500);
            ClarasAccount.ShowBalance();
            // Creates instances of the AccountHolderClass for John and Clara
            // Calls the ShowBalance method to display their initial balances

            AccountManagement accountManagement = new AccountManagement();
            // Creates an instance of the AccountManagement class to manage account operations


            accountManagement.MakeTransfer(JohnsAccount, ClarasAccount, 50);
            // Calls the MakeTransfer method to transfer funds between accounts
            // Displays the updated balances of both accounts


            Console.Read();
            
            
        }
    }
}