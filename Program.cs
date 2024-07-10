using SecondProject.Models;
Rectangle rectangle = new Rectangle();
string firstNumber;
string secondNumber;
int firstValue;
int secondValue;
bool isNumber;
do
{
    Console.WriteLine("enter first number");
    firstNumber = Console.ReadLine();
    isNumber = int.TryParse(firstNumber, out firstValue);
} while (isNumber == false);
do
{
    Console.WriteLine("enter first number");
    secondNumber = Console.ReadLine();
    isNumber = int.TryParse(secondNumber, out secondValue);
} while (isNumber == false);
Console.WriteLine( "Area of Rectangle: " + rectangle.AreaOfRectangle(firstValue, secondValue));
Console.ReadLine();