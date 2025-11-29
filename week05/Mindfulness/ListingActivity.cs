public class ListeningActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListeningActivity()
    {
        _name = "Listening";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.AddRange(new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        });
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"  --- {GetPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        _count = GetUserAnswers().Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
    public string GetPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        string randomPrompt = _prompts[i];
        _prompts.Remove(_prompts[i]);
        if (_prompts.Count == 0)
        {
            _prompts.AddRange(new List<string>
            {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?" });
        }
        return randomPrompt;
    }
    public List<string> GetUserAnswers()
    {
        List<string> answers = new List<string>();
        int count = 0;
        
        int seconds = _duration;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        Console.Write("\n");
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            answers.Add(answer);
            count++;
        }
        return answers;
    }
}