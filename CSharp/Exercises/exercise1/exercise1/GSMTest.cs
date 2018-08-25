using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class GSMTest
    {
        public GSM[] ArrayGSM()
        {
            GSM[] GSM_Arr=new GSM[5];
            return GSM_Arr;
        }
        public void DisplayInfoGSM(GSM[] GSM_Arr)
        {
            foreach (GSM element in GSM_Arr){
                Console.WriteLine("===================PHONE SPECIFICATION=====================");
                Console.WriteLine(element.ToString());
            }
        }
        public static void DisplayIPhone4S()
        {
            GSM gsm = new GSM();
            Console.WriteLine("APPLE IPHONE4S");
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
        public static void MakeCall(GSM gsm)
        {
            Console.WriteLine("Insert Date: ");
            string date = Console.ReadLine();
            Console.WriteLine("Insert Time: ");
            string time = Console.ReadLine();
            Console.WriteLine("Dialed Number: ");
            string dial_number = Console.ReadLine();
            Console.WriteLine("Insert Date: ");
            Int32 duration = Int32.Parse(Console.ReadLine());
            gsm.AddCall(new Call(date, time, dial_number, duration));
        }
    }
}
