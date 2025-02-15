public class Simple : Goal
{
    private bool _isComplete;

    public Simple(string name, string description, int points, bool isComplete) 
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"'{_name}' complete! +{_points} XP!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine($"'{_name}' is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetRepresentation()
    {
        return $"{_name} - {_description} - {_points} points - Completed: {_isComplete}";
    }

    public override string GetDetails()
    {
        return _isComplete ? $"[✓] {_name}: {_description}" : $"[ ] {_name}: {_description}";
    }

    public override string Serialize()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isComplete}";
    }
}