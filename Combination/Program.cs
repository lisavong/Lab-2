
// Combination Keypad Entry - While looop

bool doorLocked=true;

while (doorLocked)
{
    Console.WriteLine(" Please enter in your code");
    int userInput = Convert.ToInt32(Console.ReadLine());


    if (userInput!=13579)
    {
        Console.WriteLine("You entered the wrong code.");
        Console.WriteLine( "  Would you like to try again? (y/n)");
        string again=Convert.ToString(Console.ReadLine());

        if (again=="y")
        {
            doorLocked=true;
        }else
        {
            doorLocked = false;
        }
    }
    else
    {
        Console.WriteLine(" Welcome Home!");
        doorLocked=false;
    }
}

Console.WriteLine("Press any key to exit");
Console.ReadKey();
