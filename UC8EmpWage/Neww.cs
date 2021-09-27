using System;
using System.Collections.Generic;
using System.Text;

namespace UC8EmpWage
{
    class Neww
    {
        public int empWage(String cname,int empRate,int totalDays, int totalHours)
        {
            const int fullTime = 2;
            const int partTime = 1;
            int totalWage = 0;
            int empWage = 0;
            int hours = 0;
            int workingHours = 0;
            int workingDays = 0;
            while (workingDays < totalDays && workingHours < totalHours)
            {
                workingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case fullTime:
                        hours = 12;
                        break;
                    case partTime:
                        hours = 8;
                        break;
                    default:
                        hours = 0;
                        break;
                }
                workingHours = workingHours + hours;

            }
            empWage = hours * empRate;
            totalWage += empWage;
            Console.WriteLine("Totalday :" + workingDays);
            Console.WriteLine("TotalHours:" + workingHours);
            Console.WriteLine("Employee Wage new:" + empWage);
            return totalWage;


        }
    }
}
