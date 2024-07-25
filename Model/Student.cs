using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Model
{
    internal class Student
    {
        public string studName { get; set; }
        public int studId { get; set; }

        public void StudentInfo()
        {
            Console.WriteLine($"Student ID{studId}/nStudent Name: {studName}");
        }
    }
}
