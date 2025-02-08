class MainMenu
{
    public void DisplayMenu()
    {
        Console.Write("What's your name? ");
        string userName = Console.ReadLine();

        while(true)
        {
            Console.WriteLine($"What are we doing today, {userName}?");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();

            if (choice == "4")
            break;

            Activity activity = null;

            if (choice == "1")
                activity = new BreathingActivity(userName);

            else if (choice == "2")
                activity = new ReflectionActivity(userName);

            else if (choice == "3")
                activity = new ListingActivity(userName);


            if (activity != null)
            {
                if (activity is BreathingActivity breathingActivity)
                    breathingActivity.Run();

                if (activity is ReflectionActivity reflectionActivity)
                    reflectionActivity.Run();

                if (activity is ListingActivity listingActivity)
                    listingActivity.Run();
            }

            else
            {
                Console.WriteLine("That wasn't a choice. Try again.");
                Thread.Sleep(2000);
            }


        }
    }
}