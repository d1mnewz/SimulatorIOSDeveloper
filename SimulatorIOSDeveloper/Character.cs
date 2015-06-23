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
            this.CurrentDevices.Add(new Device("IPhone", "4c", 2012));
            this.CurrentDevices.Add(new Device("MacBook", "Pro Retina 13`", 2014));
            this.CharacterStats = new Stats();
        }
        // add functions to do something(listen to music etc)

    }

    
   
   
}
