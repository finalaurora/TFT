using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class WorkerTest
    {
        public List<Worker> Workers= new List<Worker>();
        StudentTest test = new StudentTest();
        public WorkerTest(List<Worker> workers)
        {
            Workers = workers;
        }
        public WorkerTest()
        {

        }
        public void Add10Workers()
        {
            Workers.Add(new Worker("Chris", "Kyle", 100, 6));
            Workers.Add(new Worker("Chris", "Vern", 100, 4));
            Workers.Add(new Worker("Robert", "Kyle", 100, 6));
            Workers.Add(new Worker("Chris", "Berner", 120, 5));
            Workers.Add(new Worker("Dean", "Vri", 26, 6));
            Workers.Add(new Worker("Eric", "Byte", 114, 10));
            Workers.Add(new Worker("Cole", "Cher", 20, 3.5));
            Workers.Add(new Worker("Mike", "Svern", 10, 6));
            Workers.Add(new Worker("Vanelle", "Kyle", 1200, 6));
            Workers.Add(new Worker("Son", "Vicker", 42, 6));
        }
        public void SortDescending()
        {
            
            Worker temp;
            for (int i = 0; i < Workers.Count; i++)
            {
                double biggest = Workers[i].MoneyPerHour();
                for (int j = i; j < Workers.Count; j++)
                {
                    if (Workers[j].MoneyPerHour() > biggest)
                    {
                        biggest = Workers[j].MoneyPerHour();
                        temp = Workers[j];
                        Workers[j] = Workers[i];
                        Workers[i] = temp;
                    }
                } 
            }
        }
        public void Print()
        {
            Console.WriteLine("========WORKERS==========(Assume that people only work on weekdays 5 per week)=====");
            foreach(Worker element in Workers)
            {
                Console.WriteLine(element.ToString()+"\tMoney Per Hour: "+element.MoneyPerHour()+" $");
            }
        }
    }
}
