using BankEncapsulationExercise;

//Exercise 1:
//Create a new Console Application in your repos folder
//name it BankEncapsulation
//Create a new public class named BankAccount
//In your BankAccount class, create the following:
//A private field of type double named balance with a value of 0
//Define a method named Deposit that will accept a double and store that value in the balance field
//Define a method named Deposit, Withdrawal, GetBalance that will return the amount stored in the balance field
//In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.
//Once finished save, commit, and push back to Github

var bankaccount1 = new BankAccount();


Console.WriteLine($"Hello, your balance is ${bankaccount1.GetBalance()}");
Console.Write($"How much would you like to deposit?  ");
double x = double.Parse(Console.ReadLine());

bankaccount1.Deposit(x);
Console.WriteLine($"Your new balance is ${bankaccount1.GetBalance()}");

Console.Write($"How much would you like to withdraw? ");
double y = double.Parse(Console.ReadLine());
bankaccount1.Withdrawal(y);
Console.WriteLine($"Your new balance is ${bankaccount1.GetBalance()}");

if (bankaccount1.GetBalance() < 0)
{
    Console.WriteLine("You have reached your maximum allowable withdrawal limit");
}