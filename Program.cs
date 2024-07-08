using SecondProject.Models;

string? a;
do
{
    Console.WriteLine("enter a number");
    a = Console.ReadLine();
    //I am going to check whether the input is null, number or string.
    int n;
    bool isNumeric = int.TryParse(a, out n);
    if (a == null || a == string.Empty)
    {
        Console.WriteLine("this value is null or empty");
    }
    else if (isNumeric)
    {
        Console.WriteLine("this is a number");
        if (FindEvenNumber.evenNumber(n))
        {
            Console.WriteLine("this is even number");
        }
    }
    else if (a != null && a.ToLower() != "break")
    {
        Console.WriteLine("this is string");
    }

} while (a.ToLower() != "break");
