using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{

    class Program
    {
        static void Main(string[] args)
        {

            Display disp = new Display(1920, 1080, 5.5, 16000000);
            Battery bat = new Battery("HuaWei litePower 0233",1, 15.5, 2.3);
            MobilePhone Nova = new MobilePhone("Nova 2i", "HuaWei", "Chris Kyle", 699, new GSM(bat, disp));
            Console.WriteLine(Nova.ToString());
            GSMTest.DisplayIPhone4S();
            GSMCallHistoryTest calltest = new GSMCallHistoryTest();
            GSMCallHistoryTest.AddCalls();
            GSMCallHistoryTest.PrintCallHistory();
            GSMCallHistoryTest.PrintCallPrice();
            GSMCallHistoryTest.RemoveLongestCall();
            GSMCallHistoryTest.ClearHistory();
            Console.Write("\nPress any key to exit... ");
            Console.ReadLine();
            
            
            
        }
    }
}
