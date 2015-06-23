using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            this.AddDevice("iPhone", "4c", 2014);
           // this.AddDevice("IPhone", "4c", 2015);
            this.CharacterStats = new Stats();
        }
        public void AddDevice(String name, String model, int year)
        {
            // well done!

            // if not contains such a device already
            if (!this.CurrentDevices.Select(x => x.Name.ToLower()).Contains(name.ToLower()))
                this.CurrentDevices.Add(new Device(name, model, year));
            else
            {
                if (year > CurrentDevices.First(x => x.Name.Equals(name)).Year)
                {
                    this.CurrentDevices.Remove(CurrentDevices.First(x => x.Name.Equals(name)));
                    this.CurrentDevices.Add(new Device(name, model, year));
                }
            }
            
        }
        // add functions to do something(listen to music etc)

    }

    
   
   
}
