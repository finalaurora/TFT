using System;
using System.Collections;
using System.ComponentModel;

namespace exercise3
{
    class Program
    {
        public static void Warning(int i)
        {
            if (i == 1)
            {
                Console.WriteLine("Option not found! Please re-input option.");
            }
            else return;
        }

        static void Main(string[] args)
        {
            string s;
            int status=0;
            WorkerTest worker = new WorkerTest();
            StudentTest student = new StudentTest();
            while (true)
            {
                Console.Clear();
                Program.Warning(status);
                Console.WriteLine("1. Test Workers");
                Console.WriteLine("2. Test Students");
                Console.WriteLine("3. Test Humans");
                Console.Write("Choose your option (type \"exit\" to end program): ");
                s = Console.ReadLine();

                switch (s)
                {
                    case "1":
                        {
                            Console.Clear();
                            status = 0;
                            worker.Workers.Clear();
                            worker.Add10Workers();
                            worker.Print();
                            worker.SortDescending();
                            worker.Print();
                            Console.WriteLine("Press any key to exit..");
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            status = 0;
                            student.Students.Clear();
                            student.Add10Students();
                            student.Print();
                            student.SortAscendingByGrade();
                            student.Print();
                            Console.WriteLine("Press any key to exit..");
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            status = 0;
                            ArrayList array = new ArrayList();
                            array = Test.NewList(worker, student);
                            Test.Print(array);
                            Test.SortList(array);
                            Test.Print(array);
                            Console.WriteLine("Press any key to exit..");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            status = 1;
                            break;
                        }
                    case "exit":
                        {
                            System.Environment.Exit(1);
                            break;
                        }

                }
            }

        }

    }
}
