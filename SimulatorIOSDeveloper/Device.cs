using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorIOSDeveloper
{
    public class Device
    {

        // you can buy only one item of every class
        // 1 iphone, 1 macbook, 1 ipod, 1 ipad, 1 applewatch
        // to do check
        // if u have already one iphone (for example)
        // it replaces by newer one
        public String Name;
        public String Model;
        public int Year;

        // public int DaysInUse; // is it worth it?
        public Device()
        {
            this.Name = "invalid";
            this.Model = "invalid";
            this.Year = 1990;
        }
        public Device(String name, String model, int year)
        {
            this.Name = name;
            this.Model = model;
            this.Year = year;

        }
    }
}
