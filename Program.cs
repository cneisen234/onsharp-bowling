// See https://aka.ms/new-console-template for more information
Random random = new Random();
int totalGameScore = 0;
Console.WriteLine("Welcome to OnSharp Bowling, press enter to start a new game!");
Console.ReadLine();
int firstFrameFirstShot = random.Next(0, 11);
int firstFramePinsLeft = 10 - firstFrameFirstShot;
int totalFirstFrame = 0;
if(firstFrameFirstShot == 10) {
Console.WriteLine("Strike!");
totalFirstFrame = 10;
} else {
Console.WriteLine($"You knocked {firstFrameFirstShot} pins down!");
Console.WriteLine("press enter to bowl again");
Console.ReadLine();
int firstFrameSecondShot = random.Next(0, firstFramePinsLeft + 1);
totalFirstFrame = firstFrameFirstShot + firstFrameSecondShot;
if(totalFirstFrame == 10) {
Console.WriteLine("Spare!");
}
Console.WriteLine($"You knocked {firstFrameSecondShot} pins down!");
}
Console.WriteLine($"Your total for the first frame is {totalFirstFrame}");
totalGameScore += totalFirstFrame;
Console.WriteLine($"Your current overall score is {totalGameScore}");
Console.WriteLine("press enter to start the next frame");
Console.ReadLine();