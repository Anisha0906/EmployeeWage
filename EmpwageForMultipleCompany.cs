using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class EmpwageForMultipleCompany
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public static int CalculateMultipleCoWage(string company, int EMP_RATE_PER_HOUR, int NUM_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs < MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;

                Random random = new Random();
                int empCheck = random.Next(0, 3);//0,1,2
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;// totalEmpHrs=totalEmpHrs+empHrs
                Console.WriteLine("Day {0} and empHrs {1}", totalWorkingDays, totalEmpHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine();
            Console.WriteLine("Total Emp Wage for Company " + company + " is: " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
