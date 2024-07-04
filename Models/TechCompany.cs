using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Models
{
    internal class TechCompany : Company
    {
        public string MainProduct { get; set; }

        public int Budget { get; set; }
        //public override int CompanyRavenue()
        //{
        //    return NumberOfEmployee * 100 / 2;

        //}

    }
}
