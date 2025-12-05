public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent(); // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event.
    public abstract bool IsComplete(); // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    public virtual string GetDetailsString() // This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
    {
        return $"[ ] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation(); // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
}