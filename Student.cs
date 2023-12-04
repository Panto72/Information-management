using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherandStudent_salaryAndMarks
{
    internal class Student:Persion
    {
        public string Faculty { get; set; }
        public string Department {  get; set; }
        public int Semester { get; set; }
        public double CGPA {  get; set; }
        public double credit {  get; set; }
        public double Total_Cost()
        {

            double total = credit *5000;
            return total;
        }
        public double TransportCost()
        {

            double TC = Semester *3000;
            return TC;
        }

    }
}
