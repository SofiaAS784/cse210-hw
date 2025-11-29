public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity()
    {
        _name = "name";
        _description = "description";
        _duration = 60;
    }
    public void SetTime(int time)
    {
        _duration = time;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int time)
    {
        List<string> spinnerStrings = new List<string>();
        spinnerStrings.AddRange(new List<string>
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\"
        });

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}