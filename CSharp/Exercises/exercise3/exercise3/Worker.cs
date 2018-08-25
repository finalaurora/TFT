using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Worker:Human
    {
        public Worker(double weekSalary, double workHoursPerDay)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }
        public Worker()
        {
            WeekSalary = 0;
            WorkHoursPerDay = 0;
        }
        public Worker(string firstName,string lastName, double weekSalary, double workHoursPerDay)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
            FirstName = firstName;
            LastName = lastName;
        }
        public double WeekSalary
        {
            get;
      
            set;
           
        }
        public double WorkHoursPerDay
        {
            get; set;
        }
        public double MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5);
        }
        public override string ToString()
        {
            return base.ToString()+"\t"+WeekSalary+"$\t"+WorkHoursPerDay+"hour(s)";
        }
    }
}
