// I modified the code to avoid getting the same question/prompt until all of them are used by the user in the same session.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");
        Activity activity = new Activity();
        string userOption = "0";
        while (userOption != "4")
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start breathing program");
            Console.WriteLine("2. Start reflecting program");
            Console.WriteLine("3. Start listing program");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userOption = Console.ReadLine();

            if (userOption == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                Console.Write("How long, in seconds, would you like for your session? ");
                string secString = Console.ReadLine();
                int seconds = int.Parse(secString);
                breathingActivity.SetTime(seconds);
                breathingActivity.Run();
            }
            else if (userOption == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.DisplayStartingMessage();
                Console.Write("How long, in seconds, would you like for your session? ");
                string secString = Console.ReadLine();
                int seconds = int.Parse(secString);
                reflectionActivity.SetTime(seconds);
                reflectionActivity.Run();
            }
            else if (userOption == "3")
            {
                ListeningActivity listeningActivity = new ListeningActivity();
                listeningActivity.DisplayStartingMessage();
                Console.Write("How long, in seconds, would you like for your session? ");
                string secString = Console.ReadLine();
                int seconds = int.Parse(secString);
                listeningActivity.SetTime(seconds);
                listeningActivity.Run();
            }
        }
    }
}