using System;
namespace exercise1
{
    internal class Battery
    {
        string Model { get; set; }
        double HoursTalk { get; set; }
        double HoursIdle { get; set; }
        string Type { get; set; }
        enum BatteryType
        {
            None=0,
            Li_Ion=1,
            NiMH=2,
            NiCd=3,
        }
        public Battery()
        {
            this.Type = Enum.GetName(typeof(BatteryType),0);
            this.Model = "";
            this.HoursIdle = 0;
            this.HoursTalk = 0;
        }
        public Battery(string model,int num, double hoursTalk, double hoursIdle)
        {
            this.Type = Enum.GetName(typeof(BatteryType),num);
            this.Model = model;
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
        }
        public override string ToString()
        {
            return "\nBattery Model: "+this.Model
                +"\nBattery Type:"+this.Type
                +"\nHours Talk: "+this.HoursTalk+" hour(s)"+
                "\nHours Idle: "+this.HoursIdle+" hour(s)";
        }
        
    }
}