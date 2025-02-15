public class Checklist : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    public Checklist(string name, string description, int points, int amountCompleted, int target, int bonus, bool isComplete) 
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        if (_isComplete) // if already complete, prevent increments
        {
            Console.WriteLine($"'{_name}' is already complete.");
            return;
        }

        _amountCompleted++;
        Console.WriteLine($"'{_name}' recorded! +{_points} XP!");

        if (_amountCompleted >= _target)
        {
            _isComplete = true;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"BONUS! You completed '{_name}' and earned an extra {_bonus} XP!");
            Console.ResetColor();
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetRepresentation()
    {
        return $"{(IsComplete() ? "[✓]" : "[ ]")} {_name}: {_description} - {_points} points - Completed: {_amountCompleted}/{_target} times";
    }

    public override string GetDetails()
    {
        return $"{(IsComplete() ? "[✓]" : "[ ]")} {_name}: {_description} - Completed {_amountCompleted}/{_target} times";
    }

    public override string Serialize()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}|{_isComplete}";
    }
}