

using System.Diagnostics;


int counts = 0;
Random random = new Random();
int winNumber = random.Next(1, 500);
Console.WriteLine(winNumber);
Stopwatch timer = new Stopwatch();
timer.Start();

while (true)
{
    Console.Clear();
    Console.WriteLine(winNumber);
    Console.WriteLine("\t\t\t\"Guess The Number\"");
    Console.Write("\n\nEnter your number from 1 to 500\nor enter 0 for exit\n>");
    int.TryParse(Console.ReadLine(), out int number);

    if (number == 0)
    {
        Console.WriteLine("bye");
        break;
    }

    ++counts;

    if (number > winNumber)
    {
        Console.WriteLine("no, the win number is lesser\nPress any key to continue");
        Console.ReadKey();
        continue;
    }

    if (number < winNumber)
    {
        Console.WriteLine("no, the number is bigger\nPress any key to continue");
        Console.ReadKey();
        continue;
    }

    timer.Stop();
    Console.WriteLine("You win!!!");
    Console.WriteLine($"Number of tries: {counts}\nTime elapsed: {timer.Elapsed}");

    Console.Write("if you want to stop the program enter 0 else if you want to repeat type 1\n>");
    int.TryParse(Console.ReadLine(), out int choice);

    if (choice == 0)
    {
        Console.WriteLine("bye bye");
        break;
    }
       
    else if (choice == 1)
    {
        winNumber = random.Next(1, 500);
        Console.WriteLine(winNumber);
        timer.Restart();
        Console.WriteLine("Okay, guess number again!!!");
        continue;
    }
}