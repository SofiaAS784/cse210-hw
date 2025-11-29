public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectionActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts.AddRange(new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless." });
        _questions.AddRange(new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        });
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        DisplayPrompt();
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        int seconds = _duration;
        while (seconds > 0)
        {
            DisplayQuestions();
            ShowSpinner(15);
            seconds -= 15;
            if (seconds < 0)
            {
                seconds += (15 - seconds);
                DisplayQuestions();
                ShowSpinner(seconds);
                seconds = 0;
            }
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        string randomPrompt = _prompts[i];
        _prompts.Remove(_prompts[i]);
        if (_prompts.Count == 0)
        {
            _prompts.AddRange(new List<string>
            {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless." });
        }
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int i = random.Next(_questions.Count);
        string randomQuestion = _questions[i];
        _questions.Remove(_questions[i]);
        if (_questions.Count == 0)
        {
            _questions.AddRange(new List<string>
            {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?" });
        }
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n  --- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
    }
    public void DisplayQuestions()
    {
        Console.Write($"\n> {GetRandomQuestion()} ");
    }
}