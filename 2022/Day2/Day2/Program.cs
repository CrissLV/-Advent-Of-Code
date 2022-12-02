// See https://aka.ms/new-console-template for more information

//Enemy
//A = Rock
//B = Paper
//C = Scissors
//Me
//X = Rock = 1
//Y = Paper = 2
//Z = Scissors = 3
//Win = 6
//Lost = 0
//Draw = 3
//Par2----
//X = Lose
//Y = Draw
//Z = Win

var guide = File.ReadAllLines(@"Input.txt");
var predicts = new List<int>();
var predicts2 = new List<int>();
foreach (var gu in guide)
{
    switch (gu) //Part1
    {
        case "A X":predicts.Add(1+3);break;
        case "A Y":predicts.Add(2+6);break;
        case "A Z":predicts.Add(3+0);break;
        case "B X":predicts.Add(1 + 0);break;
        case "B Y":predicts.Add(2 + 3);break;
        case "B Z":predicts.Add(3 + 6);break;
        case "C X":predicts.Add(1 + 6);break;
        case "C Y":predicts.Add(2 + 0);break;
        case "C Z":predicts.Add(3 + 3);break;
    }
    switch (gu) //Part2
    {
        case "A X": predicts2.Add(3 + 0); break;
        case "A Y": predicts2.Add(1 + 3); break;
        case "A Z": predicts2.Add(2 + 6); break;
        case "B X": predicts2.Add(1 + 0); break;
        case "B Y": predicts2.Add(2 + 3); break;
        case "B Z": predicts2.Add(3 + 6); break;
        case "C X": predicts2.Add(2 + 0); break;
        case "C Y": predicts2.Add(3 + 3); break;
        case "C Z": predicts2.Add(1 + 6); break;
    }


}
var totalScore = predicts.Sum();
var totalScore2 = predicts2.Sum();
Console.WriteLine("Part 1 = " + totalScore);
Console.WriteLine("Part 2 = " + totalScore2);






//var caleries = File.ReadAllLines(@"Input.txt");
//var caleriesByElf = new List<int>();
//var totalCaleriesByElf = 0;
//foreach (var cal in caleries)
//{
//    if (cal != String.Empty)
//    {
//        totalCaleriesByElf += int.Parse(cal);
//    }
//    else
//    {
//        caleriesByElf.Add(totalCaleriesByElf);
//        totalCaleriesByElf = 0;
//        continue;
//    }
//}
//var topCaleries = caleriesByElf.OrderByDescending(x => x).Take(1);
//Console.WriteLine("Part1: " + topCaleries.Sum());
//var top3Caleries = caleriesByElf.OrderByDescending(x => x).Take(3);
//Console.WriteLine("Part2: " + top3Caleries.Sum());
//Console.ReadLine();
