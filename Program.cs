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

int secondFrameFirstShot = random.Next(0, 11);
int secondFramePinsLeft = 10 - secondFrameFirstShot;
int totalSecondFrame = 0;
if(secondFrameFirstShot == 10) {
Console.WriteLine("Strike!");
totalSecondFrame = 10;
} else {
Console.WriteLine($"You knocked {secondFrameFirstShot} pins down!");
Console.WriteLine("press enter to bowl again");
Console.ReadLine();
int secondFrameSecondShot = random.Next(0, secondFramePinsLeft + 1);
totalSecondFrame = secondFrameFirstShot + secondFrameSecondShot;
if(totalSecondFrame == 10) {
Console.WriteLine("Spare!");
}
Console.WriteLine($"You knocked {secondFrameSecondShot} pins down!");
}
Console.WriteLine($"Your total for the second frame is {totalSecondFrame}");
totalGameScore += totalSecondFrame;
Console.WriteLine($"Your current overall score is {totalGameScore}");
Console.WriteLine("press enter to start the next frame");
Console.ReadLine();

int thirdFrameFirstShot = random.Next(0, 11);
int thirdFramePinsLeft = 10 - thirdFrameFirstShot;
int totalThirdFrame = 0;
if(thirdFrameFirstShot == 10) {
Console.WriteLine("Strike!");
totalThirdFrame = 10;
} else {
Console.WriteLine($"You knocked {thirdFrameFirstShot} pins down!");
Console.WriteLine("press enter to bowl again");
Console.ReadLine();
int thirdFrameSecondShot = random.Next(0, thirdFramePinsLeft + 1);
totalThirdFrame = thirdFrameFirstShot + thirdFrameSecondShot;
if(totalThirdFrame == 10) {
Console.WriteLine("Spare!");
}
Console.WriteLine($"You knocked {thirdFrameSecondShot} pins down!");
}
Console.WriteLine($"Your total for the third frame is {totalThirdFrame}");
totalGameScore += totalThirdFrame;
Console.WriteLine($"Your current overall score is {totalGameScore}");
Console.WriteLine("press enter to start the next frame");
Console.ReadLine();

int forthFrameFirstShot = random.Next(0, 11);
int forthFramePinsLeft = 10 - forthFrameFirstShot;
int totalForthFrame = 0;
if(forthFrameFirstShot == 10) {
Console.WriteLine("Strike!");
totalForthFrame = 10;
} else {
Console.WriteLine($"You knocked {forthFrameFirstShot} pins down!");
Console.WriteLine("press enter to bowl again");
Console.ReadLine();
int forthFrameSecondShot = random.Next(0, forthFramePinsLeft + 1);
totalForthFrame = forthFrameFirstShot + forthFrameSecondShot;
if(totalForthFrame == 10) {
Console.WriteLine("Spare!");
}
Console.WriteLine($"You knocked {forthFrameSecondShot} pins down!");
}
Console.WriteLine($"Your total for the forth frame is {totalForthFrame}");
totalGameScore += totalForthFrame;
Console.WriteLine($"Your current overall score is {totalGameScore}");
Console.WriteLine("press enter to start the next frame");
Console.ReadLine();

int fifthFrameFirstShot = random.Next(0, 11);
int fifthFramePinsLeft = 10 - fifthFrameFirstShot;
int totalFifthFrame = 0;
if(fifthFrameFirstShot == 10) {
Console.WriteLine("Strike!");
totalFifthFrame = 10;
} else {
Console.WriteLine($"You knocked {fifthFrameFirstShot} pins down!");
Console.WriteLine("press enter to bowl again");
Console.ReadLine();
int fifthFrameSecondShot = random.Next(0, fifthFramePinsLeft + 1);
totalFifthFrame = fifthFrameFirstShot + fifthFrameSecondShot;
if(totalFifthFrame == 10) {
Console.WriteLine("Spare!");
}
Console.WriteLine($"You knocked {fifthFrameSecondShot} pins down!");
}
Console.WriteLine($"Your total for the fifth frame is {totalFifthFrame}");
totalGameScore += totalFifthFrame;
Console.WriteLine($"Your current overall score is {totalGameScore}");
Console.WriteLine("press enter to start the next frame");
Console.ReadLine();

int sixthFrameFirstShot = random.Next(0, 11);
int sixthFramePinsLeft = 10 - sixthFrameFirstShot;
int totalSixthFrame = 0;
if(sixthFrameFirstShot == 10) {
Console.WriteLine("Strike!");
totalSixthFrame = 10;
} else {
Console.WriteLine($"You knocked {sixthFrameFirstShot} pins down!");
Console.WriteLine("press enter to bowl again");
Console.ReadLine();
int sixthFrameSecondShot = random.Next(0, sixthFramePinsLeft + 1);
totalSixthFrame = sixthFrameFirstShot + sixthFrameSecondShot;
if(totalSixthFrame == 10) {
Console.WriteLine("Spare!");
}
Console.WriteLine($"You knocked {sixthFrameSecondShot} pins down!");
}
Console.WriteLine($"Your total for the sixth frame is {totalSixthFrame}");
totalGameScore += totalSixthFrame;
Console.WriteLine($"Your current overall score is {totalGameScore}");
Console.WriteLine("press enter to start the next frame");
Console.ReadLine();

int seventhFrameFirstShot = random.Next(0, 11);
int seventhFramePinsLeft = 10 - seventhFrameFirstShot;
int totalSeventhFrame = 0;
if(seventhFrameFirstShot == 10) {
Console.WriteLine("Strike!");
totalSeventhFrame = 10;
} else {
Console.WriteLine($"You knocked {seventhFrameFirstShot} pins down!");
Console.WriteLine("press enter to bowl again");
Console.ReadLine();
int seventhFrameSecondShot = random.Next(0, seventhFramePinsLeft + 1);
totalSeventhFrame = seventhFrameFirstShot + seventhFrameSecondShot;
if(totalSeventhFrame == 10) {
Console.WriteLine("Spare!");
}
Console.WriteLine($"You knocked {seventhFrameSecondShot} pins down!");
}
Console.WriteLine($"Your total for the seventh frame is {totalSeventhFrame}");
totalGameScore += totalSeventhFrame;
Console.WriteLine($"Your current overall score is {totalGameScore}");
Console.WriteLine("press enter to start the next frame");
Console.ReadLine();

int eighthFrameFirstShot = random.Next(0, 11);
int eighthFramePinsLeft = 10 - eighthFrameFirstShot;
int totalEighthFrame = 0;
if(eighthFrameFirstShot == 10) {
Console.WriteLine("Strike!");
totalEighthFrame = 10;
} else {
Console.WriteLine($"You knocked {eighthFrameFirstShot} pins down!");
Console.WriteLine("press enter to bowl again");
Console.ReadLine();
int eighthFrameSecondShot = random.Next(0, eighthFramePinsLeft + 1);
totalEighthFrame = eighthFrameFirstShot + eighthFrameSecondShot;
if(totalEighthFrame == 10) {
Console.WriteLine("Spare!");
}
Console.WriteLine($"You knocked {eighthFrameSecondShot} pins down!");
}
Console.WriteLine($"Your total for the eighth frame is {totalEighthFrame}");
totalGameScore += totalEighthFrame;
Console.WriteLine($"Your current overall score is {totalGameScore}");
Console.WriteLine("press enter to start the next frame");
Console.ReadLine();

int ninthFrameFirstShot = random.Next(0, 11);
int ninthFramePinsLeft = 10 - ninthFrameFirstShot;
int totalNinthFrame = 0;
if(ninthFrameFirstShot == 10) {
Console.WriteLine("Strike!");
totalNinthFrame = 10;
} else {
Console.WriteLine($"You knocked {ninthFrameFirstShot} pins down!");
Console.WriteLine("press enter to bowl again");
Console.ReadLine();
int ninthFrameSecondShot = random.Next(0, ninthFramePinsLeft + 1);
totalNinthFrame = ninthFrameFirstShot + ninthFrameSecondShot;
if(totalNinthFrame == 10) {
Console.WriteLine("Spare!");
}
Console.WriteLine($"You knocked {ninthFrameSecondShot} pins down!");
}
Console.WriteLine($"Your total for the ninth frame is {totalNinthFrame}");
totalGameScore += totalNinthFrame;
Console.WriteLine($"Your current overall score is {totalGameScore}");
Console.WriteLine("press enter to start the next frame");
Console.ReadLine();

int tenthFrameFirstShot = random.Next(0, 11);
int tenthFramePinsLeft = 10 - tenthFrameFirstShot;
int totalTenthFrame = 0;
if(tenthFrameFirstShot == 10) {
Console.WriteLine("Strike!");
totalTenthFrame = 10;
} else {
Console.WriteLine($"You knocked {tenthFrameFirstShot} pins down!");
Console.WriteLine("press enter to bowl again");
Console.ReadLine();
int tenthFrameSecondShot = random.Next(0, tenthFramePinsLeft + 1);
totalTenthFrame = tenthFrameFirstShot + tenthFrameSecondShot;
if(totalTenthFrame == 10) {
Console.WriteLine("Spare!");
}
Console.WriteLine($"You knocked {tenthFrameSecondShot} pins down!");
}
Console.WriteLine($"Your total for the tenth frame is {totalTenthFrame}");
totalGameScore += totalTenthFrame;
Console.WriteLine($"Your final score is {totalGameScore}, thanks for playing!");
