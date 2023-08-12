// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Specialized;
using TypesContainer;

Dictionary<int, int> game = new Dictionary<int, int>{};

Random random = new Random();
int totalGameScore = 0;
Console.WriteLine("Welcome to OnSharp Bowling, press enter to start a new game!");
Console.ReadLine();

for (int i = 1; i <= 10; i++)
{
    int total = 0;
    int firstShot = random.Next(0, 11);
    int secondShot = 0;
    int thirdShot = 0;
    
    Console.WriteLine($"Starting frame {i}");
    int pinsLeft = 10 - firstShot;
    
    if(i < 10) {
        if(firstShot == 10) {
            Console.WriteLine($"{(FrameTypes)0}!");
            game.Add(i, 0);
            total = 10;
        } else {
            Console.WriteLine($"You knocked {firstShot} pins down!");
            Console.WriteLine("press enter to bowl again");
            Console.ReadLine();
            secondShot = random.Next(0, pinsLeft + 1);
            total = firstShot + secondShot;
                if(total == 10) {
                    Console.WriteLine($"{(FrameTypes)1}!");
                    game.Add(i, 1);
                } else {
                    game.Add(i, 2);
                }
            Console.WriteLine($"You knocked {secondShot} pins down! Press enter to continue");
        }
        Console.ReadLine();
    } else {
        total = firstShot;
        Console.WriteLine($"You knocked {firstShot} pins down!");
        Console.WriteLine("press enter to bowl again");
        Console.ReadLine();
        if(firstShot == 10) {
        secondShot = random.Next(0, 11);
        } else {
        secondShot = random.Next(0, pinsLeft + 1);
        }
        total = firstShot + secondShot;
        Console.WriteLine($"You knocked {secondShot} pins down! Press enter to continue");
        Console.ReadLine();
        if(total >= 10) {
            if(total == 10) {
                thirdShot = random.Next(0, 11);
            } else {
                int pinsLeftForThirdShot = 10 - secondShot;
                thirdShot = random.Next(0, pinsLeftForThirdShot + 1);
            }
                total += thirdShot;
                Console.WriteLine($"You knocked {thirdShot} pins down! Press enter to continue");
                Console.ReadLine();
        }
    }
        Console.WriteLine($"Your total for frame {i} is {total}");
        totalGameScore += total;
    if(i != 1) {
        if(game[i - 1] == 0) {
            totalGameScore += firstShot + secondShot;
        } else if(game[i - 1] == 1) {
            totalGameScore += firstShot;
        }
    }
    Console.WriteLine("---------------------------");
    Console.WriteLine($"Frame {i} Summary");
    Console.WriteLine("---------------------------");
    Console.WriteLine($"First Shot: {firstShot}");
    Console.WriteLine($"Second Shot: {secondShot}");
        if(i == 10) {
            Console.WriteLine($"Third Shot: {thirdShot}");
        }
    Console.WriteLine($"Frame Total: {total}");
    Console.WriteLine("---------------------------");
    Console.WriteLine($"Your current overall score is {totalGameScore}");
    Console.WriteLine("press enter to continue");
    Console.ReadLine();
}
Console.WriteLine($"Your final score is {totalGameScore}, thanks for playing!");