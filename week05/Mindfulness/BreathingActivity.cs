public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.Write($"\nBreathe in... ");
        ShowCountDown(2);
        Console.Write($"\nNow breathe out... ");
        ShowCountDown(3);
        Console.WriteLine("");
        int seconds = _duration;
        while (seconds > 0)
        {
            Console.Write($"\nBreathe in... ");
            ShowCountDown(4);
            Console.Write($"\nNow breathe out... ");
            ShowCountDown(6);
            Console.WriteLine("");
            
        }
        DisplayEndingMessage();
    }
}