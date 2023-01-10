using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class ComputeEmployeeWage
    {
        const int isFullTime = 1;
        const int isPartTime = 2;
        int workingDays = 20;
        int wagePerHour = 20;
        int totalWorkingHrs = 100;

        public void CalculateEmpWage()
        {
            int empHrs;
            int dailyWage;
            int totalWage = 0;
            int totalNoOfHrs = 0;
            int totalWorkingDays = 0;

            Random random = new Random();
            while (totalWorkingDays < workingDays && totalNoOfHrs <= totalWorkingHrs)
            {
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;

                    case isPartTime:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;

                }

                totalNoOfHrs += empHrs;
                dailyWage = wagePerHour * empHrs;
                totalWage += dailyWage;
                totalWorkingDays++;
            }

            Console.WriteLine("Total Wage for Month is: " + totalWage);
            Console.WriteLine("Total No of hours are {0} and working days are {1}", totalNoOfHrs, totalWorkingDays);
        }
    }
}
