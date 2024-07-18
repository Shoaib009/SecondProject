using System;
using System.Collections.Generic;

List<int> number = new List<int> { 1, 2, 3 };
number.Add(123);
foreach (int i in number)
{
    Console.WriteLine(i);
}
number.RemoveAt(3);
number.Add(11);
Console.WriteLine("\n");
for (int i = 0; i < number.Count; i++)
{
    Console.WriteLine(number[i]);
}