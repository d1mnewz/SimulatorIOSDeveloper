using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
        private Random rnd = new Random();
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
        public void ToFreelance()
        {
            var t = Task<int>.Factory.StartNew(() =>
            {
                return rnd.Next(1, 100);
            });
            t.Wait();

            if (t.Result < this.CharacterStats.ProgrammingValue)
            {
                int moneyGain = rnd.Next(1, 10) * this.CharacterStats.ProgrammingValue;
                int skillGain = rnd.Next(1, 3);
                this.Money += moneyGain;
                this.CharacterStats.ProgrammingValue += skillGain;
                this.CharacterStats.SocialValue -= 1;
                // to add sound
                MessageBox.Show(String.Format("Money Gain - {0}\nSkill Point Gain - {1}", moneyGain, skillGain), "Success!");
            }
            else MessageBox.Show("Unlucky i cannot find a project that i can do properly %(", "Dayum!");
        }
        // add functions to do something(listen to music etc)

    }

    
   
   
}
