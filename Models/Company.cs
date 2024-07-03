using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Models
{
    internal class Company
    {
        public String? CompanyName { get; private set; }
        public int EmployeeNumber { get; set; }

        public void Work()
        {
            Console.WriteLine("This Company is creating Softwares");
            //this.CompanyName = "abc";
            Console.WriteLine(this.CompanyName);
        }
        public void SetCompanyName(int CompanyNumber)
        {
            //1 = abc
            //2 = cdf
            //3 = ghi
            //4 = lkj
            ////5 = opu
            //if (CompanyNumber == 1) { CompanyName = "abc"; }
            //else if (CompanyNumber == 2) { CompanyName = "cdf"; }
            //else if (CompanyNumber == 3) { CompanyName = "ghi"; }
            //else if (CompanyNumber == 4) { CompanyName = "lkj"; }
            //else if (CompanyNumber == 5) { CompanyName = "opu"; }
            //else { Console.WriteLine("Value not found"); }
            //Console.WriteLine(CompanyName);
            switch (CompanyNumber)
            {
                case 1:
                    CompanyName = "ABC";
                    break;
                case 2:
                    CompanyName = "CDE";
                    break;
                case 3:
                    CompanyName = "FGH";
                    break;
                case 4:
                    CompanyName = "IJK";
                    break;
                case 5:
                    CompanyName = "LMN";
                    break;
                default:
                    Console.WriteLine("We dont find any value");
                    break;

            }
            Console.WriteLine(CompanyName);


        }
    }
}
