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
            this.Money = 10;
            this.CurrentStatus = "ididot retard";
            this.Name = "John Doe";
            this.CurrentDevices = new List<Device>();
            this.AddDevice("iPhone", "4c", 2014);
           // this.AddDevice("IPhone", "4c", 2015);
            this.CharacterStats = new Stats();
        }

        public bool PayMoney(int value)
        {
            if (this.Money - value >= 0)
            {
                this.Money -= value;
                return true;
            }
            else
            {
                
                return false;
            }
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
                this.CharacterStats.IncreaseBy(Stats.StatsNames.Programming, skillGain);
                this.CharacterStats.DecreaseBy(Stats.StatsNames.Social, 1);
                // to add sound
                MessageBox.Show(String.Format("Money Gain - {0}\nSkill Point Gain - {1}", moneyGain, skillGain), "Success!");
            }
            else MessageBox.Show("Unlucky you cannot find a project that you can do properly %(", "Dayum!");
        }

        public void ToDrinkSmoothie()
        {
            int skillGain = rnd.Next(1, 3);
            int healthGain = rnd.Next(1, 2);
            String finalStr = "";
            bool enoughMoney = this.PayMoney(3);
            if (enoughMoney)
            {
                this.CharacterStats.IncreaseBy(Stats.StatsNames.Health, healthGain);
                if (rnd.Next(1, 3) == 1)
                {

                    this.CharacterStats.IncreaseBy(Stats.StatsNames.Social, skillGain);
                    finalStr += String.Format("You`ve met a cool hipster girl. She told you about new music genre in Finland!\nSocial skills increased by {0}\n", skillGain);
                }
                finalStr += String.Format("Health increased by {0}", healthGain);
                MessageBox.Show(finalStr, "Worth it!");
            }
            else MessageBox.Show("Not enough money", "WTF?");
        }
        // add functions to do something(listen to music etc)

    }

    
   
   
}
