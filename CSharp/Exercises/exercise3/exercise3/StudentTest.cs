using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class StudentTest
    {
        public List<Student> Students = new List<Student>();

        public StudentTest(List<Student> students)
        {
            Students = students;
        }
        public StudentTest()
        {

        }
        public void Add10Students()
        {
            Students.Add(new Student("Chris", "Kyle", 9.2));
            Students.Add(new Student("Chris", "Connor", 7.5));
            Students.Add(new Student("Eric", "Miller", 4.0));
            Students.Add(new Student("Bob", "Kyle", 10));
            Students.Add(new Student("Mike", "Gale", 9.2));
            Students.Add(new Student("Anna", "Kyle", 4.5));
            Students.Add(new Student("Alpha", "Zulu", 7.3));
            Students.Add(new Student("Robert", "Valde", 1.2));
            Students.Add(new Student("Oleg", "Kyle", 6.5));
            Students.Add(new Student("Vladimir", "Putin", 7.4));
        }
        public void SortAscendingByGrade()
        {
            for(int i = 0; i < Students.Count; i++)
            {
                double smallest=Students[i].GetGrade();
                Student temp;
                for(int j = i; j < Students.Count; j++)
                {
                    if (Students[j].GetGrade() < smallest)
                    {
                        smallest = Students[j].GetGrade();
                        temp = Students[j];
                        Students[j] = Students[i];
                        Students[i] = temp;
                        
                    }
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("--------------LIST OF STUDENTS--------------------");
            foreach(Student element in Students)
            {
                Console.WriteLine(element.ToString());
            }
        }
    }
}
