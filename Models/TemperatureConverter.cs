using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLearningCShrapProject
{
    public class TemperatureConverter
    {
        public float FarhenheitToCelcius(float temperatureValue)
        {
            var temp = 5 / 9f;
            var temp1 = temperatureValue - 32f;
            temp = temp1 * temp;
            return temp;
        }
        public float CelciusToFarhenheit(float temperatureValue)
        {
            float temp = 9 / 5f;
            temp = temperatureValue * temp;
            temp = temp + 32;
            return temp;
        }
    }
}
