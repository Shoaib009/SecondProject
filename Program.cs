using SecondProject.Models;

Calculator calculator = new Calculator();
string firstInput;
string secondInput;
string thirdInput;
int firstNumber;
int secondNumber;
int seletecOperation;
bool isNumber;
do
{
    Console.WriteLine("enter first number");
    firstInput = Console.ReadLine();
    isNumber = int.TryParse(firstInput, out firstNumber);
} while (isNumber == false);
do
{
    Console.WriteLine("enter Second number");
    secondInput = Console.ReadLine();
    isNumber = int.TryParse(secondInput, out secondNumber);
} while (isNumber == false);
do
{
    Console.WriteLine("for addition press 1, for subtraction press 2, for multiplication press 3, for division press 4");
    thirdInput = Console.ReadLine();
    isNumber = int.TryParse(thirdInput, out seletecOperation);
    if (isNumber)
    {
        if (0 < seletecOperation && seletecOperation < 5)
        {
            switch (seletecOperation)
            {
                case 1:
                    Console.WriteLine(calculator.add(firstNumber, secondNumber));
                    break;
                case 2:
                    Console.WriteLine(calculator.minus(firstNumber, secondNumber));
                    break;
                case 3:
                    Console.WriteLine(calculator.multiply(firstNumber, secondNumber));
                    break;
                case 4:
                    Console.WriteLine(calculator.divide(firstNumber, secondNumber));
                    break;
            }
        }
        else
        {
            Console.WriteLine("please select the number between 1 to 4.");
        }

    }
    else
    {
        Console.WriteLine("please select the correct number to perform that operation.");
    }
} while (isNumber == false || seletecOperation < 1 || seletecOperation > 4);
//first the input is number.
//second the number is in between 1 to 4.
//input is number and input is between 1 to 4.
//input is not a number or input is less then 1 or great then 4 . 
