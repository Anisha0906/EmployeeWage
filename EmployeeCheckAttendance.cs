using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class EmployeeCheckAttendance
    {
        public static void EmployeePresentAbsent()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);//0,1
            Console.WriteLine("Random Generated value " + empCheck);
            if (empCheck == 0)
            {
                Console.WriteLine("Employee Present");
            }
            else
            {
                Console.WriteLine("Employee Absent");
            }
        }
    }
}
