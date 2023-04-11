string input = "";
Console.WriteLine("Hello, Welcome to the number analyzer");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();

do
{
    Console.WriteLine($"{name}, please enter a number between 1 and 100");
    int num = int.Parse(Console.ReadLine());

    if (num < 1 || num > 100)
    {
        Console.WriteLine($"That is not between 1 and 100 {name}, you should try again");
    }

    else
    {
        if (num % 2 == 1)
        {
            if (num < 60)
            {
                Console.WriteLine("That number is odd and less that 60");
            }
            else
            {
                Console.WriteLine("That number is odd and greater than 60 ");
            }
        }
        else
        {
            if (num < 25)
            {
                Console.WriteLine("That number is even and less than 25");

            }
            else if (num <= 60)
            {
                Console.WriteLine("That number is even and between 26 and 60 inclusive");

            }
            else
            {
                Console.WriteLine("That number is even and greater than 60");
            }
        }
       
    }
    Console.WriteLine($"Would you like to continue {name}? y to continue, any other key to exit");
    input = Console.ReadLine();
    if (input != "y")
    {
        Console.WriteLine("Goodbye!");
    }
} while (input == "y") ;


