
using SecondProject.Model;
using System;
using System.Collections.Generic;


Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
Teacher teacher = new Teacher();
do
{
    Console.WriteLine("enter teacher id: ");
    teacher.teacherId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter teacher name: ");
    teacher.teacherName = Console.ReadLine();
    keyValuePairs.Add(teacher.teacherId, teacher.teacherName);
} while (keyValuePairs.Count <= 2);


foreach (var kvp in keyValuePairs)
{
    Console.WriteLine("Teacher ID is {0} \nTeacher Name is {1}", kvp.Key, kvp.Value);
}


