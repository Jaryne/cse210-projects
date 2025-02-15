public class Manager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private int _xp;
    private int _xpThreshold;
    private string _dailyChallenge;
    private Dictionary<string, bool> _achievements;
    private Random _random;

    public Manager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _xp = 0;
        _xpThreshold = 100;
        _random = new Random();
        _achievements = new Dictionary<string, bool>
        {
            {"First Goal Completed", false},
            {"Level 5 Reached", false}
        };

        SetDailyChallenge();
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n= ETERNAL QUEST =");
            Console.WriteLine("1. View Stats");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Create a New Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Return IRL");
            Console.Write("Choose your fate: ");

            switch (Console.ReadLine())
            {
                case "1": DisplayStatus(); break;
                case "2": ListGoals(); break;
                case "3": CreateGoal(); break;
                case "4": RecordEvent(); break;
                case "5": SaveGoal(); break;
                case "6": LoadGoal(); break;
                case "7": Console.WriteLine("See ya!"); running = false; break;
                default: Console.WriteLine("No use in deviating. Choose wisely."); break;
            }
        }
    }

    private void DisplayStatus() => Console.WriteLine($"Level: {_level} | XP: {_xp}/{_xpThreshold} | Total Score: {_score}\nDaily Challenge: {_dailyChallenge}");

    private void GainXP(int points)
    {
        _xp += points;
        Console.WriteLine($"You gained {points} XP!");

        while (_xp >= _xpThreshold)
        {
            _xp -= _xpThreshold;
            LevelUp();
        }
    }

    private void LevelUp()
    {
        _level++;
        _xpThreshold += 50;
        Console.WriteLine($"LEVEL UP! You are now Level {_level}!");

        if (_level == 5 && !_achievements["Level 5 Reached"])
        {
            _achievements["Level 5 Reached"] = true;
            Console.WriteLine("Achievement Unlocked: Level 5 - You're getting stronger!");
        }
    }

    private void SetDailyChallenge()
    {
        string[] challenges = { "Complete 3 goals", "Gain 200 XP", "Finish a checklist" };
        _dailyChallenge = challenges[_random.Next(challenges.Length)];
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet. Lock in and create a new one!");
            return;
        }

        Console.WriteLine("\nYour current quests:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }

    public void CreateGoal()
    {
        Console.Write("\nEnter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter XP value: ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points) || points < 0)
        {
            Console.Write("Enter a valid XP value: ");
        }

        Console.WriteLine("\nSelect goal type: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string type = Console.ReadLine();

        Goal newGoal = null;
        switch (type)
        {
            case "1":
                newGoal = new Simple(name, description, points, false);
                break;

            case "2":
                newGoal = new Eternal(name, description, points);
                break;

            case "3":
                Console.Write("Enter number of target completions: ");
                int target;
                while (!int.TryParse(Console.ReadLine(), out target) || target <= 0)
                {
                    Console.Write("Enter a valid target number: ");
                }

                Console.Write("Enter the bonus XP: ");
                int bonus;
                while (!int.TryParse(Console.ReadLine(), out bonus) || bonus < 0)
                {
                    Console.Write("Enter a valid bonus XP value: ");
                }

                newGoal = new Checklist(name, description, points, 0, target, bonus, false);
                break;

            default:
                Console.WriteLine("X Invalid choice.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully! Let's go!");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to complete yet. Create one first!");
            return;
        }

        Console.WriteLine("Select goal to record an event for:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }

        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            Goal selected = _goals[choice - 1];
            selected.RecordEvent();
            _score += selected.GetPoints();
            GainXP(selected.GetPoints());
        }
        else
        {
            Console.WriteLine("X Invalid choice.");
        }
    }

    private void SaveGoal()
    {
        Console.Write("Enter a filename to save: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // Save filename at the top
                writer.WriteLine($"Filename|{filename}");

                // Save stats
                writer.WriteLine($"Stats|{_score}|{_level}|{_xp}|{_xpThreshold}");

                // Save all goals
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.Serialize());
                }
            }
            Console.WriteLine($"Goals, stats, and filename saved successfully in {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data: {ex.Message}");
        }
    }

    private void LoadGoal()
    {
        Console.Write("Enter a filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved data found with that filename.");
            return;
        }

        try
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');

                    if (parts[0] == "Filename") // Read filename but don't overwrite it
                    {
                        Console.WriteLine($"Loading from: {parts[1]}");
                    }
                    else if (parts[0] == "Stats") // Load stats
                    {
                        _score = int.Parse(parts[1]);
                        _level = int.Parse(parts[2]);
                        _xp = int.Parse(parts[3]);
                        _xpThreshold = int.Parse(parts[4]);
                    }
                    else // Load goals
                    {
                        _goals.Add(Goal.Deserialize(line));
                    }
                }
            }
            Console.WriteLine($"Goals, stats, and filename loaded successfully from {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading data: {ex.Message}");
        }
    }
}