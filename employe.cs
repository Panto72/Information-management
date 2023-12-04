using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherandStudent_salaryAndMarks
{
    internal class employe:Persion
    {
        public string job_location {  get; set; }
        public string post {  get; set; }
        public double Basic_Salary { get; set; }
        public double Transport_Cost { get; set; }
        public double PF { get; set; }
        public double Bonus { get; set; }


        public double Salary()
        {
            Transport_Cost = Basic_Salary * 0.4;
            PF = Basic_Salary * 0.2;
            Bonus = Basic_Salary * 0.5;
            double Total_salary = Basic_Salary + Bonus + Transport_Cost - PF;
            return Total_salary;
        }
    }
}
