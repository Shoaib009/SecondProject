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

        public virtual void CarFeulType() { Console.WriteLine("car use petrol as a feul"); }
    }
    internal class Honda : Car
    {
        public void NewModel()
        {
            Console.WriteLine("this is Honda new model 2024.");
        }
        public override void CarFeulType()
        {
            Console.WriteLine("car use desel as a feul");
        }
    }
    internal class Toyota : Car
    {
        public void CompanyName()
        {
            Console.WriteLine("this is Toyota company.");
        }
        public override void CarFeulType() { Console.WriteLine("car use battery as a feul"); }
    }
}
