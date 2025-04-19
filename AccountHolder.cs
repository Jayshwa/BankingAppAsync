using System;

namespace BankingApp
{
    public class AccountHolderClass
    {

        private string _Name { get; set; }
        private float _Balance { get; set; }
        // Private fields to store the account holder's name and balance
        // The private access modifier restricts access to these fields from outside the class
        // The properties _Name and _Balance are used to encapsulate the private fields
        // The properties are used to provide controlled access to the private fields

        public AccountHolderClass( string Name, float Balance){
            // Constructor for the AccountHolderClass
            // Initializes the account holder's name and balance
            // Parameter 1: string representing the name of the account holder
            // Parameter 2: float representing the initial balance of the account holder
            // Sets the private fields _Name and _Balance to the provided values
            // The private fields are used to store the account holder's name and balance
            // The constructor is called when an instance of the class is created
            // The constructor is public, allowing access to the class from outside
            _Name = Name;
            _Balance = Balance;
            
        }

        public void ShowBalance(){
            Console.WriteLine($"{_Name} has {_Balance} GBP");
        }

        public void AddFunds(float amount){
            Console.WriteLine($"Adding {amount} GBP to {_Name}'s account...");
            _Balance += amount;
            // Simulates a delay of 2 seconds to mimic an asynchronous operation
            Console.WriteLine($"{_Name}'s new balance is {_Balance} GBP");
        }

        public void WithdrawFunds(float amount){
            Console.WriteLine($"Withdrawing {amount} GBP from {_Name}'s account...");
            _Balance -= amount;
            // Simulates a delay of 2 seconds to mimic an asynchronous operation
            Console.WriteLine($"{_Name}'s new balance is {_Balance} GBP");
        }

        public string GetName(){
            // Returns the name of the account holder due to the private access modifier
            // The method is public, allowing access to the name from outside the class
            return _Name;
        }
        public float GetBalance(){
            // Returns the name of the account holder due to the private access modifier
            // The method is public, allowing access to the name from outside the class
            return _Balance;
        }
    }
}