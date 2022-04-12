// See https://aka.ms/new-console-template for more information
using EMPLOYEE_COMPUTATION_ASSIGNMENT;
Console.WriteLine("Hello, World!");
Uc1_Attendance.Attendance();
Uc2_Wage.Wage();
Uc3_Parttime.Wage();
Uc4_SwitchEmpWage.EmpWage();
Uc5_20WorkingDays.Emp20DaysWage();
Uc6_Max100hours.EmpMax100HrsWage();
Uc7_Using_Wage_Method.method();
Uc8_Wage_To_Multiple_Company.wagemethod();

Console.WriteLine();
Console.WriteLine("Uc9 Begin here ***********************************************");
Uc9_Emp_Wage_Using_obj dMart = new Uc9_Emp_Wage_Using_obj("DMart",20,2,10);
Uc9_Emp_Wage_Using_obj relience = new Uc9_Emp_Wage_Using_obj("Relience", 10, 4, 20);
dMart.computeEmpWage();
Console.WriteLine(dMart.toString());
relience.computeEmpWage();
Console.WriteLine(relience.toString());