// See https://aka.ms/new-console-template for more information
Random random = new Random();
Console.WriteLine("Welcome to OnSharp Bowling, press enter to start a new game!");
Console.ReadLine();
int firstFrameFirstShot = random.Next(0, 10);
int firstFramePinsLeft = 10 - firstFrameFirstShot;
Console.WriteLine($"You knocked {firstFrameFirstShot} pins down!");
Console.WriteLine("press enter to bowl again");
Console.ReadLine();
int firstFrameSecondShot = random.Next(0, firstFramePinsLeft);
Console.WriteLine($"You knocked {firstFrameSecondShot} pins down!");
Console.WriteLine("press enter to bowl again");