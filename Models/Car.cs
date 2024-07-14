using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Models
{
    internal class Car
    {
        public string companyName { get; set; }
        public int model { get; set; }
        public string carColor { get; set; }
        public void CarStart() { Console.WriteLine("car is start now... "); }
        public void CarStop() { Console.WriteLine("car is stoped now."); }
    }
    internal class Honda : Car
    {
        public void NewModel()
        {
            Console.WriteLine("this is Honda new model 2024.");
        }
    }
}
