public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;    // removed start and endtime cause i realized its just a countdown

    protected string _userName; // Exceeding requirements**
    protected static int sessionCount = 0; // Track # of sessions completed.

    public Activity(string name, string description, string userName)
    {
        _name = name;
        _description = description;
        _userName = userName;
    }

    public virtual void Start()
    {
        Console.WriteLine($"\nStarting {_name}..\n");
        Console.WriteLine(_description);
        Console.Write("How long would your session be (in seconds)? ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid duration (e.g 1, 15, 20): ");
        }

        Console.WriteLine("Get ready to begin..");
        ShowCountdown(3);
    }

    public virtual void End() // virtual so it can be overridden  by a subclass
    {
        sessionCount++;
        Console.WriteLine("Great job, "+ _userName +"! Well done.");
        ShowSpinner(3);
        Console.WriteLine($"You completed {_name} for {_duration} second/s.");
        Console.WriteLine($"Total sessions completed: {sessionCount}.");
        ShowSpinner(3);

    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in {i}.."); // \r  to return to starting line
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }
    protected void ShowSpinner(int seconds)
    {
        char[] spinner = {'/', '-', '\\', '|'};
        for (int i=0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % spinner.Length]}");
            Thread.Sleep(250);
        }

        Console.WriteLine();
    }
}