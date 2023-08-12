// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Specialized;

ListDictionary game = new ListDictionary();
Random random = new Random();
int totalGameScore = 0;
Console.WriteLine("Welcome to OnSharp Bowling, press enter to start a new game!");
Console.ReadLine();

for (int i = 1; i <= 10; i++)
{
    int total = 0;
    int firstShot = random.Next(0, 11);
    Console.WriteLine($"Starting frame {i}");
    game.Add($"frame{i}firstShot", firstShot);
    int pinsLeft = 10 - firstShot;
    if(firstShot == 10) {
    Console.WriteLine("Strike!");
    game.Add($"frame{i}total", 10);
    total = 10;
    } else {
    Console.WriteLine($"You knocked {firstShot} pins down!");
    Console.WriteLine("press enter to bowl again");
    Console.ReadLine();
    int secondShot = random.Next(0, pinsLeft + 1);
    total = firstShot + secondShot;
    if(total == 10) {
    Console.WriteLine("Spare!");
    }
    game.Add($"frame{i}total", total);
    Console.WriteLine($"You knocked {secondShot} pins down!");
    }
    Console.WriteLine($"Your total for frame {i} is {total}");
    totalGameScore += total;
    Console.WriteLine($"Your current overall score is {totalGameScore}");
    Console.WriteLine("press enter to start the next frame");
    Console.ReadLine();
}
Console.WriteLine($"Your final score is {totalGameScore}, thanks for playing!");
game.Add("gameTotal", totalGameScore);
