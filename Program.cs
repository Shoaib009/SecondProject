
using SecondProject.Model;
using System;
using System.Collections.Generic;


Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
do
{
    Teacher teacher = new Teacher();
    Console.WriteLine("enter teacher id: ");
    teacher.teacherId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter teacher name: ");
    teacher.teacherName = Console.ReadLine();
    keyValuePairs.Add(teacher.teacherId, teacher.teacherName);
} while (keyValuePairs.Count <= 4);
keyValuePairs.Remove(0);
foreach (var kvp in keyValuePairs)
{
    Console.WriteLine("Teacher ID is {0} \nTeacher Name is {1}",kvp.Key, kvp.Value);
}


