
// for loop

int userInput;
string goAgain="y";

do
{
    Console.Write("Enter a number greater than 1  :");
    userInput=Convert.ToInt32(Console.ReadLine());


    for (int i = userInput; i > 0; i--)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Reverse!");

    for (int i = 0; i <= userInput; i++)
    {

        Console.WriteLine(i);
    }

    
    Console.Write("Should we do this again? (y/n)");
    goAgain= Convert.ToString(Console.ReadLine());

} while (goAgain=="y");


Console.WriteLine("Thanks for playing along");
Console.WriteLine("Press any key to exit");
Console.ReadLine();







