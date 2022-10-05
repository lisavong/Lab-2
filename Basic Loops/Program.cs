// Hello world - do while loop

string userInput;

do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Should we do this again? (y/n)");
    userInput= Convert.ToString(Console.ReadLine());      

} while (userInput=="y");

Console.WriteLine("It was nice seeing you!");
Console.WriteLine("Goodbye\n");
Console.WriteLine("Press any key to exit");
Console.ReadKey();
