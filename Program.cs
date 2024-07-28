using SecondProject.Model;
using System;
using System.Collections.Generic;

List<Student> names = new List<Student>();
List<int> studentId = new List<int>();
List<string> studentName = new List<string>();
string nameCheck;
int idCheck;

do
{
    Student student = new Student();
    Console.WriteLine("enter student name: ");
    student.studName = Console.ReadLine();
    Console.WriteLine("enter student ID: ");
    student.studId = Convert.ToInt32(Console.ReadLine());
    names.Add(student);
} while (names.Count < 3);

foreach (var items in names)
{
    studentId.Add(items.studId);
}
studentId.Sort();
foreach (var item in studentId) { 
Console.WriteLine($"student id is {item}.");
}
foreach (var item in names)
{
    studentName.Add(item.studName);
}
studentName.Sort();
foreach (var item in studentName)
{

Console.WriteLine($"student name is {item}.");
}

do
{
    Console.WriteLine("enter student name you want to check: ");
    nameCheck = Console.ReadLine();
    if (studentName.Contains(nameCheck))
    {
        Console.WriteLine($"we have found {nameCheck} in the list.");
    }
    else { Console.WriteLine("try again as we didnt find this name in the list."); }
} while (!studentName.Contains(nameCheck));
Console.WriteLine("loop exit");

do
{
    Console.WriteLine("enter studnet id you want to check: ");
    idCheck = Convert.ToInt32(Console.ReadLine());
    if (studentId.Contains(idCheck))
    {
        Console.WriteLine($"we have found this id {idCheck} in the list.");
    }
    else
    {
        Console.WriteLine("please try again as we didnt find this id in the list.");
    }
} while (!studentId.Contains(idCheck));
Console.WriteLine("loop exit");




















//foreach (Student item in names)
//{
//    item.StudentInfo();
//}