//string[] names = new string[] { "Mac", "Alex", "Mosh", "Max" };

//Console.WriteLine(names.Length);
//Array.Sort(names);
//Array.Reverse(names);   
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}
/*
int[] numbers;

Console.WriteLine("write the size of array in number");
int size = int.Parse(Console.ReadLine());
numbers = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine("enter the elements");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0;i < size; i++)
{
    Console.WriteLine(numbers[i]+"/n");
}*/
string[] names;
Console.WriteLine("enter the size of the array:");
int size = int.Parse(Console.ReadLine());

names = new string[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine("write the name: ");
    names[i] = Console.ReadLine();
}
Console.WriteLine("\nbelow are the given names:");
Array.Reverse(names);

for (int i = 0;i < size; i++)
{
    Console.WriteLine(names[i]);
}
