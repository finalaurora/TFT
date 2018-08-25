using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class MobilePhone
    {
        String Model;
        String Manufacturer;
        String Owner;
        double Price;
        GSM PhoneGSM;
        public MobilePhone()
        {
            this.Model = null;
            this.Manufacturer = null;
            this.Owner = null;
            this.Price = 0;
            this.PhoneGSM = null;
        }

        public MobilePhone(string model, string manufacturer, string owner, double price, GSM phoneGSM)
        {
            Model = model;
            Manufacturer = manufacturer;
            Owner = owner;
            Price = price;
            PhoneGSM = phoneGSM;
        }
        public override string ToString()
        {
            return "Phone Model: "+this.Model+
                "\nManufacturer: "+this.Manufacturer+
                "\nOwner: "+this.Owner+
                "\nPrice: "+this.Price+"$"
                +this.PhoneGSM.ToString();
        }
    }
}
