// See https://aka.ms/new-console-template for more information
Random random = new Random();
Console.WriteLine("Welcome to OnSharp Bowling, press enter to start a new game!");
Console.ReadLine();
int firstFrameFirstShot = random.Next(0, 10);
Console.WriteLine($"You knocked {firstFrameFirstShot} pins down!");