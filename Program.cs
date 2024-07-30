
using SecondProject.Model;
using System;
using System.Collections.Generic;


Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
Teacher teacher = new Teacher();
int dictKey;
string dicValue;
int myKey = 0;
int temp = 0;
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

do
{
    Console.WriteLine("enter the key to check its value: ");
    dictKey = Convert.ToInt32(Console.ReadLine());
    if (keyValuePairs.ContainsKey(dictKey))
    {
        Console.WriteLine("The value of entered key is {0} and its key is {1}", keyValuePairs[dictKey], dictKey);
    }
    else
    {
        Console.WriteLine("your entered key is not found in the list please try again");
    }
} while (keyValuePairs.ContainsKey(dictKey) == false);

do
{
    Console.WriteLine("enter the value to check its if its in the list: ");
    dicValue = Console.ReadLine();
    if (keyValuePairs.ContainsValue(dicValue))
    {
        myKey = keyValuePairs.FirstOrDefault(x => x.Value == dicValue).Key;
        Console.WriteLine("The value of entered key is {0} and its key is {1}", keyValuePairs[myKey], myKey);
        keyValuePairs.Remove(myKey);
        temp = 1;
    }
    else
    {
        Console.WriteLine("your entered key is not found in the list please try again");
    }
} while (temp != 1);

foreach (var kvp in keyValuePairs)
{
    Console.WriteLine("Teacher ID is {0} \nTeacher Name is {1}", kvp.Key, kvp.Value);
}