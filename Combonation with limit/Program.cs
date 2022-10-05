
// Combination Keypad Entry - While looop

bool doorLocked = true;
int attempts = 5;

Console.WriteLine("Hello! Keep in mind you only have 5 tries..");

while (doorLocked)
{
    Console.WriteLine(" Please enter in your code");
    int userInput = Convert.ToInt32(Console.ReadLine());


    if (userInput!=13579)
    {
        Console.WriteLine("  Oops! You entered the wrong code.");
        Console.Write("Try again : ");
        string again = Convert.ToString(Console.ReadLine());

        if (attempts<=5)
        {
            attempts++;
            doorLocked=true;
        }
        else
        {
            Console.WriteLine("  Sorry. Too many attempts. Come back in 24 hours");
            Console.WriteLine("Bye!");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
    else
    {
        Console.WriteLine(" Welcome Home!");
        Console.WriteLine("Press one more key to leave this prompt");
        Console.ReadKey();
        doorLocked=false;
    }
}


