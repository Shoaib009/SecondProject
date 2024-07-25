using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SecondProject.Model
{
    internal class Division
    {

        public int numinator { get; set; }
        public int denominator { get; set; }


        public int DividTheseNumbers(int numerator, int denominator)
        {
            try
            {
            return DivisionFunc(numerator, denominator);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int DivisionFunc(int value1, int value2)
        {
           
            try
            {
                return value1 / value2;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
                //Console.WriteLine(ex.Message);
            }

        }


    }
}
