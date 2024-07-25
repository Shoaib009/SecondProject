using SecondProject.Model;
using System;
using System.Collections.Generic;

List<Student> names = new List<Student>();

do
{
    Student student = new Student();
    Console.WriteLine("enter student name: ");
    student.studName = Console.ReadLine();
    Console.WriteLine("enter student ID: ");
    student.studId = Convert.ToInt32(Console.ReadLine());
    names.Add(student);
} while (names.Count < 3);

//names.Sort();
names.TrimExcess();

foreach (Student item in names)
{
    item.StudentInfo();
}