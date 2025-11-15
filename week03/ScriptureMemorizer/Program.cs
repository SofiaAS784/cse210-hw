// I think I got it, but sometimes when I run the code, it suddenly stop working at the end. I don't if is a problem
// of my code, or just something that happens. Also, I didn't have time to add something extra, but I try to accomplish
// the stretch challenge of just hiding the words that are not already hidden.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Ether", 12, 4);
        string verse = "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.";
        Scripture scripture = new Scripture(reference, verse);

        string userAction = "";
        Console.Clear();
        while (userAction == "")
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userAction = Console.ReadLine();
            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }

            if (userAction == "")
            {
                Random random = new Random();
                int number = random.Next(3, 7);
                scripture.HideRandomWords(number);
                Console.Clear();
            }
        }
    }
}