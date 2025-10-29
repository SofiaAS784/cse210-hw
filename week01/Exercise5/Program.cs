using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userSquareNumber = SquareNumber(userNumber);
        DisplayResult(userName, userSquareNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumberText = Console.ReadLine();
        int userNumber = int.Parse(userNumberText);
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int userSquareNumber = userNumber * userNumber;
        return userSquareNumber;
    }
    static void DisplayResult(string userName, int userSquareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {userSquareNumber}");
    }
}