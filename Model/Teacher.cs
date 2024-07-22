using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Model
{
    internal class Teacher
    {
        public int teacherId { get; set; }
        public string teacherName { get; set; } 

        public void TeacherInfo()
        {
            Console.WriteLine($"Teacher ID is {teacherId}, and teacher name is {teacherName}.");
        }
    }
}
