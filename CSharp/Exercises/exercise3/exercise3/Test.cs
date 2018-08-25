using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Test
    {
        static public ArrayList NewList(WorkerTest w, StudentTest s)
        {
            ArrayList list = new ArrayList();
            for(int i=0; i < w.Workers.Count; i++)
            {
                list.Add(w.Workers[i]);
            }
            for (int i = 0; i < s.Students.Count; i++)
            {
                list.Add(s.Students[i]);
            }
            return list;
        }
        static public void SortList(ArrayList list)
        {
            Object tmp;
            for(int i = 0; i < list.Count; i++)
            {
                Object biggest = list[i];
                for(int j = 0; j < list.Count; j++)
                {
                    if ((Human)list[i] < (Human)list[j])
                    {
                        biggest = list[j];
                        tmp = list[j];
                        list[j] = list[i];
                        list[i] = tmp;
                    }
                }
            }
        }
        static public void Print(ArrayList list)
        {
            Console.WriteLine("==========MIXED LIST=========");
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
    }
}
