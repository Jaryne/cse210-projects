public class Eternal : Goal
{
    public Eternal(string name, string description, int points) 
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"'{_name}' recorded! +{_points} XP. Keep going!");
        Console.ResetColor();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetRepresentation()
    {
        return $"{_name} - {_description} - {_points} points (infinite)";
    }

    public override string Serialize()
    {
        return $"Eternal|{_name}|{_description}|{_points}";
    }
}