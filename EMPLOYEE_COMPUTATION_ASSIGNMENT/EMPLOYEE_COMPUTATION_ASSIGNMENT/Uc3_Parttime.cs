using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEE_COMPUTATION_ASSIGNMENT
{
    internal class Uc3_Parttime
    {
        public static void Wage()
        {
            Console.WriteLine();
            Console.WriteLine("Uc3 Begin here ***********************************************");
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Emp_Rate_Per_Hour = 20;

            int empHrs = 0;
            int empWage = 0;
            Random obj = new Random();
            int num = obj.Next(0, 3);
            if (num == Is_Full_Time)
            {
                empHrs = 8;
            }
            else if (num == Is_Part_Time)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee wage : " + empWage);
        }
    }
}
