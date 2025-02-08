public class ListingActivity : Activity
{
    private List<string> listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are some of your personal heroes?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
    };

    private List<string> items = new List<string>();
    public ListingActivity(string userName) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you this as many things as you can.", userName){}
    public void Run()
    {
        Start();
        Random rand = new Random();
        string prompt = listingPrompts[rand.Next(listingPrompts.Count)];
        Console.WriteLine(prompt);
        ShowCountdown(3);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
            elapsed += 2;
        }

        End();
    }
}
