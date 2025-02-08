public class ReflectionActivity : Activity
{
    private List<string> reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult.",
        "Think of the last time you helped someone in need.",
        "Think of a time when you did something selfless."
    };

    private List<string> reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "What made this time different than other times when you were not as successful?",
        "How did you feel after?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself going through this?",
        "What could you learn from this experience that applies to other situations?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string userName) : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", userName){}
    // constructor call

    public void Run()
    {
        Start();
        Random rand = new Random();
        string prompt = reflectionPrompts[rand.Next(reflectionPrompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            string _question = reflectionQuestions[rand.Next(reflectionQuestions.Count)];
            Console.WriteLine(_question);
            ShowSpinner(5);
            elapsed += 5;
        }

        End();
    }
}