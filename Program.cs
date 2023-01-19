using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage");
            Console.WriteLine("Choose Option\n 1.Check Absent or Present\t 2.Calculate Daily Wage\t 3.Part Time Wage\t 4.Emp Wage for month\t" +
                " 5.Total Employee Wages For Month\t 6.Compute Employeewage using class and method\t " +
                "7.Emp Wage for Multiple Company\t 8.Save Total wage for each company \n9.EmpWageBuilder");
             int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EmployeeCheckAttendance.EmployeePresentAbsent();
                    break;
                case 2:
                    DailyWage.CalculateDailyWage();
                    break;
                case 3:
                    PartTimeWage.CalculatePartTimeWage();
                    break;
                case 4:
                    EmpWageSwitchCase.WageForMonth();
                    break;
                case 5:
                    WagesForMonthWhileLoop.CalculateWage();
                    break;
                case 6:
                    ComputeEmpWages.ComputeEmpWage();
                    break;
                case 7:
                    EmpwageForMultipleCompany.CalculateMultipleCoWage("DMart", 20, 2, 10);
                    EmpwageForMultipleCompany.CalculateMultipleCoWage("BigBazar", 10, 4, 20);
                    break;
                case 8:
                    EmpWages TATA = new EmpWages("TATA", 20, 20, 100);
                    EmpWages BMW = new EmpWages("BMW", 20, 20, 100);
                    EmpWages TCS = new EmpWages("TCS", 20, 20, 100);

                    TATA.ComputeEmployeeWage();
                    Console.WriteLine(TATA.ToString());
                    BMW.ComputeEmployeeWage();
                    Console.WriteLine(BMW.ToString());
                    TCS.ComputeEmployeeWage();
                    Console.WriteLine(TCS.ToString());
                    break;
                case 9:
                    EmpWageBuilder empWageBuilderArray = new EmpWageBuilder();
                    empWageBuilderArray.addCompanyEmpWage("TATA", 20, 2, 10);
                    empWageBuilderArray.addCompanyEmpWage("BMW", 10, 4, 20);
                    empWageBuilderArray.addCompanyEmpWage("TCS", 10, 4, 20);
                    empWageBuilderArray.computeEmpWage();
                    break;

                default:
                    Console.WriteLine("Entered Wrong Choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
