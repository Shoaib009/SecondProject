using SecondProject.Model;
using System;
using System.Collections.Generic;

List<Student> names = new List<Student>();
List<int> studentId = new List<int>();
List<string> studentName = new List<string>();
string nameCheck;
int idCheck;
int acendingOrDecendingOrderId;
string acendingOrDecendingName;


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

do
{
    Console.WriteLine("Please select one number to sort student ID list accordingly \nPress 1 for Acendending Order of list:\nPress 2 for Decending order of list:");
    acendingOrDecendingOrderId = Convert.ToInt32(Console.ReadLine());
    if (acendingOrDecendingOrderId == 1)
    {
        studentId.Sort();
        foreach (var item in studentId)
        {
            Console.WriteLine($"student id is {item}.");
        }
    }
    else if (acendingOrDecendingOrderId == 2)
    {
        studentId.Reverse();
        foreach (var item in studentId)
        {
            Console.WriteLine($"student id is {item}.");
        }
    }
    else { Console.WriteLine("Please select the right number and try again"); }
} while (!(acendingOrDecendingOrderId == 1 || acendingOrDecendingOrderId == 2));


foreach (var item in names)
{
    studentName.Add(item.studName);
}
do
{
    Console.WriteLine("Please select a number to sort student name list accordingly \nPress 1 for Acending Order of list:\nPress 2 for Decending Order of list:");
    acendingOrDecendingOrderId = Convert.ToInt32(Console.ReadLine());
    if (acendingOrDecendingOrderId == 1)
    {
        studentName.Sort();
        foreach (var item in studentName)
        {

            Console.WriteLine($"student name is {item}.");
        }
    }
    else if (acendingOrDecendingOrderId == 2)
    {
        studentName.Reverse();
        foreach (var item in studentName)
        {

            Console.WriteLine($"student name is {item}.");
        }
    }
    else
    {
        Console.WriteLine("Please select the right number and try again.");
    }
} while (!(acendingOrDecendingOrderId == 1 || acendingOrDecendingOrderId == 2));

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