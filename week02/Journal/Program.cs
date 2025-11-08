// I make some modifications to the Journal class to save all the information in a cvs file. I also 
// added some messages that are displayed to the user when the action is done. 

using System;
using System.Data;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        string userOption = "0";
        while (userOption != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userOption = Console.ReadLine();
            if (userOption == "1")
            {
                string prompt = GetPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string entry = Console.ReadLine();
                Entry newEntry = new Entry();
                newEntry._date = GetDate();
                newEntry._promptText = prompt;
                newEntry._entryText = entry;

                journal.AddEntry(newEntry);
            }
            else if (userOption == "2")
            {
                journal.DisplayAll();
            }
            else if (userOption == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("You journal was successfully loaded!");
            }
            else if (userOption == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("You journal was successfully saved!");
            }
        }
    }
    static string GetPrompt()
    {
        PromptGenerator prompts = new PromptGenerator();
        prompts._prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts._prompts.Add("What is something I did today that I really liked?");
        prompts._prompts.Add("How was the nicest person I talked with today?");
        prompts._prompts.Add("How did I see the Lord's hand through this day?");
        prompts._prompts.Add("What was the strongest emotion I felt today?");
        string prompt = prompts.GetRandomPrompt();
        return prompt;
    }
    static string GetDate()
    {
        DateTime dateTime = DateTime.Now;
        string date = dateTime.ToShortDateString();
        return date;
    }
}