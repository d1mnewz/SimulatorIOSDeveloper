using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorIOSDeveloper
{
    public class Character
    {
        public String Name;
        public Stats CharacterStats;
        public double Money;
        public String CurrentStatus;
        public List<Device> CurrentDevices;

        public Character()
        {
            this.Money = 200;
            this.CurrentStatus = "ididot retard";
            this.Name = "John Doe";
            this.CurrentDevices = new List<Device>();
            this.CurrentDevices.Add(new Device("IPhone", "4c"));
            this.CurrentDevices.Add(new Device("MacBook", "Pro Retina 13`"));
        }
        // add functions to do something(listen to music etc)

    }

    public class Device
    {

        // you can buy only one item of every class
        // 1 iphone, 1 macbook, 1 ipod, 1 ipad, 1 applewatch
        // to do check
        // if u have already one iphone (for example)
        // it replaces by newer one
        public String Name;
        public String Model;
        
       // public int DaysInUse; // is it worth it?
        public Device()
        {
            Name = "invalid";
            Model = "invalid";
        }
        public Device(String name, String model)
        {
            this.Name = name;
            this.Model = model;

        }
    }
    public class Stats
    {
        public int SocialValue;
        public int HealthValue;
        public int ProgrammingValue;
        // to add some more stats

        public Stats()
        {
            this.SocialValue = 0;
            this.ProgrammingValue = 0;
            this.HealthValue = 0;

        }
    }
   
}
