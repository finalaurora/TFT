using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Student:Human
    {
        private double Grade;

        public Student(double grade)
        {
            Grade = grade;
        }
        public Student(string firstName,string lastName,double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public Student()
        {
            Grade = 0;
        }
        public double GetGrade()
        {
            return this.Grade;
        }
        public void SetGrade(double value)
        {
            this.Grade = value;
        }
        public override string ToString()
        {
            return base.ToString()+"\tGrade: "+Grade;
        }
    }
}
