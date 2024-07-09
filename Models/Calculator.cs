using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Models
{
    public class Calculator
    {
        public int add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public int minus(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public int multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public int divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
