using SecondLearningCShrapProject;

TemperatureConverter temperatureConverter = new TemperatureConverter();
string temperature;
string userSelection;
float temperatureValue;
int userValue;
bool IsNumber;
do
{
    Console.WriteLine("Fahenheit to Celcius Convertion Press 1: \nCelcius to Fahenheit convertion Press 2: ");
    userSelection = Console.ReadLine();
    IsNumber = int.TryParse(userSelection, out userValue);
    if (!IsNumber || (IsNumber && (userValue < 1 || userValue > 2)))
    {
        Console.WriteLine("Please select the right value.");
    }
} while (!IsNumber || (IsNumber && (userValue < 1 || userValue > 2)));// all conditions are true then this break out of this loop 

do
{
    if (userValue == 1)
        Console.WriteLine("Please enter Fahenheit value:");
    if (userValue == 2)
        Console.WriteLine("Please enter Celcius value:");

    temperature = Console.ReadLine();
    IsNumber = float.TryParse(temperature, out temperatureValue);
} while (IsNumber == false);

switch (userValue)
{
    case 1:
        Console.WriteLine($"Temperature Value in Celcius was {temperatureValue}, and Fahenheit value is " +
                          $"{temperatureConverter.CelciusToFarhenheit(temperatureValue)}");
        break;
    case 2:
        Console.WriteLine($"Temperature Value in Fahenheit was {temperatureValue}, and Celcius value is " +
                          $"{temperatureConverter.FarhenheitToCelcius(temperatureValue)}");
        break;
    default:
        break;
}