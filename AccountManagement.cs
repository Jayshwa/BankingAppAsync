using System;

namespace BankingApp
{
    public class AccountManagement
    {
        public async Task AddFunds(AccountHolderClass accountHolder, float amount)
        // Declares an async method that can be called on an AccountManagement object.
        // Paramater 1: Custom class data type 'AccountHolder'
        // Parameter 2: float representing the amount of funds to add
        {
            Console.WriteLine($"Adding funds to account...");
            await Task.Delay(2000);
            accountHolder.AddFunds(amount);
            // Simulates a delay of 2 seconds to mimic an asynchronous operation
            // Adds the specified amount to the account holder's balance
            Console.WriteLine($"Funds added successfully.");
        }


        public async Task MakeTransfer(AccountHolderClass sender, AccountHolderClass receiver, float amount)
        // Declares an async method that can be called on an AccountManagement object.
        // Parameter 1: Custom class data type 'AccountHolder'
        // Parameter 2: Custom class data type 'AccountHolder'
        // Parameter 3: float representing the amount to transfer
        {
            Console.WriteLine($"Transferring funds from {sender.GetName()} to {receiver.GetName()}...");
            await Task.Delay(2000);
            sender.WithdrawFunds(amount);
            receiver.AddFunds(amount);


            sender.ShowBalance();
            receiver.ShowBalance();
            // Simulates a delay of 2 seconds to mimic an asynchronous operation
            // Deducts the specified amount from the sender's account and adds it to the recipient's account
            Console.WriteLine($"Transfer completed successfully.");
            // Displays the updated balances of both accounts


        }
    }
}