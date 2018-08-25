using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Call
    {
        public string Date;
        public string Time;
        public string DialNumber;
        public Int32 Duration { get; set; }
    

        public Call()
        {
            Date = null;
            Time = null;
            DialNumber = null;
            this.Duration = 0;
        }

        public Call(string date, string time, string dialNumber, int duration)
        {
            Date = date;
            Time = time;
            DialNumber = dialNumber;
            this.Duration = duration;
        }
        public void MakeCall()
        {

        }
    }
}
