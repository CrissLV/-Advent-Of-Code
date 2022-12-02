// See https://aka.ms/new-console-template for more information


using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;


var caleries = File.ReadAllLines(@"Input.txt");
var caleriesByElf = new List<int>();
var totalCaleriesByElf = 0;
foreach (var cal in caleries)
{
    if (cal != String.Empty)
    {
        totalCaleriesByElf += int.Parse(cal);
    }
    else
    {
        caleriesByElf.Add(totalCaleriesByElf);
        totalCaleriesByElf = 0;
        continue;
    }
}
var topCaleries = caleriesByElf.OrderByDescending(x => x).Take(1);
Console.WriteLine("Part1: "+topCaleries.Sum());
var top3Caleries = caleriesByElf.OrderByDescending(x => x).Take(3);
Console.WriteLine("Part2: " + top3Caleries.Sum());
Console.ReadLine();
