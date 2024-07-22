using SecondProject.Model;
using System;
using System.Collections.Generic;

List<string> number = new List<string>();
do
{
    Student student = new Student();    
    Console.WriteLine("enter student name: ");
    student.studName = Console.ReadLine();
    number.Add(student.studName);   

} while (number.Count <= 5);

number.Sort();
number.TrimExcess();

foreach (string item in number)
{
    Console.WriteLine(item);
}