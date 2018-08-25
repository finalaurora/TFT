using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class GSMCallHistoryTest
    {
        static GSM gsm = new GSM();
        public static void AddCalls()
        {
            gsm.AddCall(new Call("20/08/2018", "18:30", "01234567890", 3600));
            gsm.AddCall(new Call("20/08/2018", "19:30", "01251577890", 360));
            gsm.AddCall(new Call("21/08/2018", "08:30", "01242574890", 18520));
            gsm.AddCall(new Call("20/08/2018", "18:30", "01234567890", 314));
            gsm.AddCall(new Call("20/08/2018", "18:30", "01215189660", 1516));
        }

        public static string PrintTimeFormat(int num)
        {
            int hour = num / 3600;
            num = num % 3600;
            int min = num / 60;
            num = num % 60;
            return hour + "h " + min + "m " + num + "s";
        }
        public static void PrintCallHistory()
        {
            if (gsm.CallHistory.Count < 1)
            {
                Console.WriteLine("Call History is empty.");
            }
            else
            {

                Console.WriteLine("================CALL HISTORY==============");
                for (int i = 0; i < gsm.CallHistory.Count; i++)
                {
                    Call element = gsm.CallHistory[i];
                    Console.WriteLine("Date: " + element.Date + " Time: " + element.Time + " Call Number: " + element.DialNumber + " Duration: " + PrintTimeFormat(element.Duration));
                }
            }
        }

        public static void PrintCallPrice()
        {
            Console.WriteLine("Total Call Price is: "+gsm.CalculatePrice(0.37)+" $");
        }
        public static int FindLongestCall()
        {
            if (gsm.CallHistory.Count < 1)
            {
                return -1;
            }
            else if(gsm.CallHistory.Count == 1)
            {
                return 0;
            }
            else
            {
                int index=0;
                int longest = 0;
                for(int i=1;i<gsm.CallHistory.Count;i++)
                {
                    if (gsm.CallHistory[i].Duration > longest)
                    {
                        index = i;
                        longest = gsm.CallHistory[i].Duration;
                    }
                }
                return index;
            } 
        }
        public static void RemoveLongestCall()
        {
            if (GSMCallHistoryTest.FindLongestCall()<0)
            {
                Console.WriteLine("History is Empty, can not remove any call!");
            }
            else
            { 
                gsm.DeleteCall(GSMCallHistoryTest.FindLongestCall());
                PrintCallPrice();
                PrintCallHistory();
            }
        }
        public static void ClearHistory()
        {
            gsm.ClearCallHistory();
            PrintCallHistory();
        }
    }
}
