public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetRepresentation();
    public abstract string Serialize();

    public virtual string GetDetails()
    {
        return $"[ ] {_name}: {_description}";
    }

    public int GetPoints()
    {
        return _points;
    }

    public static Goal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        string type = parts[0];
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);

        switch (type)
        {
            case "Simple":
                bool isComplete = bool.Parse(parts[4]);
                return new Simple(name, description, points, isComplete);

            case "Eternal":
                return new Eternal(name, description, points);

            case "Checklist":
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                bool checklistIsComplete = bool.Parse(parts[7]);
                return new Checklist(name, description, points, amountCompleted, target, bonus, checklistIsComplete);

            default:
                throw new Exception("Unknown goal type during deserialization");
        }
    }
}