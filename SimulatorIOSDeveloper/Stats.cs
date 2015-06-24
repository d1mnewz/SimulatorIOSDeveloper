using System;
using System.Collections.Generic;
using System.Linq;


namespace SimulatorIOSDeveloper
{
    public class Stats
    {
        public int SocialValue;
        public int HealthValue;
        public int ProgrammingValue;
        // to add some more stats

        public Stats()
        {
            this.SocialValue = 50;
            this.ProgrammingValue = 12;
            this.HealthValue = 90;

        }
        public enum StatsNames
        {
            Social, Health, Programming
        };
        public void IncreaseBy(StatsNames stat, int value)
        {
            switch (stat)
            {
                case StatsNames.Health:
                    if (this.HealthValue + value <= 100)
                    {
                        this.HealthValue += value;
                    }
                    else this.HealthValue = 100;
                    break;
                case StatsNames.Programming:
                    if (this.ProgrammingValue + value <= 100)
                    {
                        this.ProgrammingValue += value;
                    }
                    else this.ProgrammingValue = 100;
                    break;
                case StatsNames.Social:
                    if (this.SocialValue + value <= 100)
                    {
                        this.SocialValue += value;
                    }
                    else this.ProgrammingValue = 100;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("undefined error");
                    break;
            }
      
        }

        public void DecreaseBy(StatsNames stat, int value)
        {
            switch (stat)
            {
                case StatsNames.Health:
                    if (this.HealthValue - value >= 0)
                    {
                        this.HealthValue -= value;
                    }
                    else this.HealthValue = 0;
                    break;
                case StatsNames.Programming:
                    if (this.ProgrammingValue - value >= 0)
                    {
                        this.ProgrammingValue -= value;
                    }
                    else this.ProgrammingValue = 0;
                    break;
                case StatsNames.Social:
                    if (this.SocialValue - value >= 0)
                    {
                        this.SocialValue -= value;
                    }
                    else this.ProgrammingValue = 0;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("undefined error");
                    break;
            }

        }
    }
}
