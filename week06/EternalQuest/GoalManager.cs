using System.Formats.Asn1;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start() // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    {
        string userOption = "0";
        while (userOption != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userOption = Console.ReadLine();
            if (userOption == "1")
            {
                CreateGoal();
            }
            else if (userOption == "2")
            {
                ListGoalDetails();
            }
            else if (userOption == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                SaveGoals(filename);
            }
            else if (userOption == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                LoadGoals(filename);
            }
            else if (userOption == "5")
            {
                RecordEvent();
            }
        }
    }
    public void DisplayPlayerInfo() // Displays the players current score.
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    public void ListGoalNames() // Lists the names of each of the goals.
    {
        int count = 1;
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals)
        {
            string goalName = goal.GetGoalName();
            Console.WriteLine($"{count}. {goalName}");
            count++;
        }
    }
    public void ListGoalDetails() // Lists the details of each goal (including the checkbox of whether it is complete).
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            string goalDetails = goal.GetDetailsString();
            Console.WriteLine($"{count}. {goalDetails}");
            count++;
        }
    }
    public void CreateGoal() // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        Console.WriteLine("The type of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalSel = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDesc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPointsText = Console.ReadLine();
        int goalPoints = int.Parse(goalPointsText);
        if (goalSel == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDesc, goalPoints);
            _goals.Add(simpleGoal);
        }
        else if (goalSel == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDesc, goalPoints);
            _goals.Add(eternalGoal);
        }
        else if (goalSel == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string bonusTimesText = Console.ReadLine();
            int bonusTimes = int.Parse(bonusTimesText);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusPointsText = Console.ReadLine();
            int bonusPoints = int.Parse(bonusPointsText);
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDesc, goalPoints, bonusTimes, bonusPoints);
            _goals.Add(checklistGoal);
        }
    }
    public void RecordEvent() // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string goalNumber = Console.ReadLine();
        int index = int.Parse(goalNumber) - 1;
        int pointsEarned = _goals[index].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        _score += pointsEarned;
        Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoals(string file) // Saves the list of goals to a file.
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals(string file) // Loads the list of goals from a file.
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            if (line.Length <= 10)
            {
                int score = int.Parse(line);
                _score = score;
            }
            else
            {
                string[] parts = line.Split(":");

                string typeOfGoal = parts[0];
                string[] details = parts[1].Split(",");
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                if (typeOfGoal == "SimpleGoal")
                {
                    bool isCompleted = bool.Parse(details[3]);
                    if (isCompleted == true)
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isCompleted);
                        _goals.Add(simpleGoal);
                    }
                    else
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        _goals.Add(simpleGoal);
                    }
                }
                else if (typeOfGoal == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (typeOfGoal == "ChecklistGoal")
                {
                    int bonus = int.Parse(details[3]);
                    int target = int.Parse(details[4]);
                    int amountCompleted = int.Parse(details[5]);
                    if (amountCompleted > 0)
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                        _goals.Add(checklistGoal);
                    }
                    else
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                        _goals.Add(checklistGoal);
                    }
                }
            }
        }
    }
}