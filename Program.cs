
using SecondProject.Model;
using System;
using System.Collections.Generic;

    throw new Exception("Student object is null. ");
try
{
    Division division = new Division();
    int total;
    do
    {
        Console.WriteLine("enter the numinator value:");
        division.numinator = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter denominator value: ");
        division.denominator = Convert.ToInt32(Console.ReadLine());
     // division.DividTheseNumbers(division.numinator, division.denominator);
       // total = division.DividTheseNumbers(division.numinator, division.denominator);

    } while (division.denominator > 0);
   // Console.WriteLine(total);
}
catch (DivideByZeroException)
{

    Console.WriteLine("abc");
}

//TextWriter tw;

//try
//{
//    string path = @"D:\code\Example.txt";
//    if (!File.Exists(path))
//    {
//        File.Create(path);
//        tw = new StreamWriter(path);
//        tw.WriteLine("The very first line!");
//        tw.Close();
//    }
//    else if (File.Exists(path))
//    {
//        tw = new StreamWriter(path, true);
//        tw.WriteLine("The next line!");
//        tw.Close();
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Error occurred: {0}", ex.Message);
//}
//finally
//{
//    // clean up file object here;
//    tw = null;

//}

