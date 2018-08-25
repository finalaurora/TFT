using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class GSM
    {
        Battery GSMBattery;
        Display GSMDisplay;
        public List<Call> CallHistory
        {
            get;
            set;
            
        }
        public GSM(Battery gSMBattery, Display gSMDisplay)
        {
            GSMBattery = gSMBattery;
            GSMDisplay = gSMDisplay;
            this.CallHistory = new List<Call>();
        }
        public GSM()
        {
            GSMBattery = null;
            GSMDisplay = null;
            this.CallHistory = new List<Call>();
        }
        public static GSM IPhone4S { get; set; } = new GSM(new Battery("A1387", 1, 0, 0), new Display(640, 960, 3.5, 16000000));
        public override string ToString()
        {
            return this.GSMBattery.ToString() + this.GSMDisplay.ToString();
        }
        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }
        public void DeleteCall(int i)
        {
            this.CallHistory.RemoveAt(i);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
        public double CalculatePrice(double ppm)
        {
            double total = 0;
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                double min = this.CallHistory[i].Duration / 60;
                total += ((Math.Round(min)) * ppm);
            }
            return total;
        }
    }
}
