using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Models
{
    public class FindEvenNumber
    {

        public static bool evenNumber(int number)
        {
            //take an input and check if it is even.
            if (number % 2 == 0)
            {
                return true;
            }
            else { return false; }

        }
    }
}
