using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulatorIOSDeveloper
{
    // to make save game in file
    // load
    // but encryption to avoid cheating
    // to make a dependency with being able to work and health & mood stats
    public class Character
    {
        public String Name;
        public Stats CharacterStats;
        public double Money;
        public String CurrentStatus;
        public List<Device> CurrentDevices;
        public Random rnd = new Random();
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
        // maybe someday make sort of itunes store
        public void ListenMusic()
        {

            int moodGain = rnd.Next(1, 2);
            this.CharacterStats.IncreaseBy(Stats.StatsNames.Mood, moodGain);
            MessageBox.Show(String.Format("Mood Gain - {0}", moodGain), "Success!");


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
        public void ToCodeSwift()
        {
            int skillGain = 0;
            int randomEvent = rnd.Next(0, 100); 
            switch(randomEvent)
            {
                case 0:
                    MessageBox.Show("PornHub security spotted you making an extended adBlocker and decided to file suit against you. -50$");
                    skillGain = 3;
                    this.CharacterStats.DecreaseBy(Stats.StatsNames.Mood, 2);
                    this.Money -= 50;
                    break;
                case 4:
                    MessageBox.Show("Someone hacked 4chan again... Wasn`t it you?", "Nice one");
                    skillGain = 4;
                    break;
                case 42:
                    MessageBox.Show("You found the answer to life the universe and everything!", "42!");
                    skillGain = 5;
                    break;
                case 77 :
                    MessageBox.Show("Your startUp about levitating kangaroos in NY was spotted by a weird but super rich arabian prince. +100$.", "JackPot");
                    this.Money += 100;
                    skillGain = 5;
                    break;
                default:
                    skillGain = rnd.Next(1, 3);
                    
                    this.CharacterStats.DecreaseBy(Stats.StatsNames.Social, 1);
                    MessageBox.Show(String.Format("Skill increased by {0}", skillGain.ToString()), "Nicely done");
                    break;
            }
            this.CharacterStats.IncreaseBy(Stats.StatsNames.Programming, skillGain);




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
                int moneyGain = rnd.Next(1, 5) * this.CharacterStats.ProgrammingValue;
                int skillGain = rnd.Next(1, 3);
                this.Money += moneyGain;
                this.CharacterStats.IncreaseBy(Stats.StatsNames.Programming, skillGain);
                this.CharacterStats.DecreaseBy(Stats.StatsNames.Social, 1);
                // to add sound
                MessageBox.Show(String.Format("Money Gain - {0}\nSkill Point Gain - {1}", moneyGain, skillGain), "Success!");
            }
            else
            {
                MessageBox.Show("Unlucky you cannot find a project that you can do properly %(", "Dayum!");
            }
            t.Dispose();
        }

        // to do it from file someday
        private Dictionary<String, String> GenerateGenres()
        {
            Dictionary<String, String> res = new Dictionary<String, String>();
            res.Add("abstracto", "It’s like complextro, but more abstract than rhythmic.");
            res.Add("aussietronica", "It’s electronica. From Australia.");
            res.Add("black sludge", "A combination of black metal and sludge, the music.");
            res.Add("bubble trance", "Bubble trance is bright, upbeat trance music.");

            res.Add("catstep", "This particularly-aggressive filthstep variation is promoted most enthusiastically by the label Monstercat.");
            res.Add("deep discofox", "An goofily earnest genre featuring slick techno-disco and the occasional video.");
            res.Add("deep psychobilly", "Deeper cuts from the psychobilly genre, which draws heavily on rockabilly and punk.");
            res.Add("destroy techno", " An invented name for a particularly hard-to-describe experimental techno cluster.");
            res.Add("drone folk", " It’s like drone music made with traditional folk instruments (guitar, banjo, strings, and possibly hurdy-gurdy).");
            res.Add("electrofox", "Electro with some of the goofy earnestness of discofox.");
            res.Add("fallen angel", "Fallen angel is a dark, often-orchestral, form of metal that features female vocals.");
            res.Add("gauze pop", "A descriptive name for a subtly distinct cluster of indie pop, which needed a name.");
            res.Add("jerk", "Jerk is a hip hop dance and music from Los Angeles. It focuses on a sparse but danceable beat.");
            res.Add("mallet", "It’s not a new kind of mullet; it’s a kind of music made with mallets.");
            res.Add("shiver pop", " A descriptive name for a subtly distinct cluster of indie pop, which needed a name.");
            res.Add("solipsynthm", "Solo laptop experimentalists.");
            res.Add("spytrack", "This sounds like soundtracks to spy movies.");
            res.Add("swirl psych", "A descriptive name for a subtly distinct cluster of indie pop, which needed a name.");
            res.Add("unblack metal", "This black metal-style music takes the opposite (anti-satanist) view.");
            res.Add("vintage swoon", "Old school heartthrob crooners from the depths of time.");
            res.Add("wrestling", "The sound of wrestling stars.");
            


            return res;
        }
        // to replace string format to string builder
        
       // to do stats gain or deacreases as flying pluses or minuses via pictureboxes
        public void ToDrinkSmoothie()
        {
            int socialGain = rnd.Next(1, 3);
            int healthGain = rnd.Next(1, 2);
            int moodGain = rnd.Next(1, 2);

            StringBuilder sb = new StringBuilder();
            bool enoughMoney = this.PayMoney(3);
            if (enoughMoney)
            {
                this.CharacterStats.IncreaseBy(Stats.StatsNames.Health, healthGain);
                this.CharacterStats.IncreaseBy(Stats.StatsNames.Mood, moodGain);
                if (rnd.Next(1, 3) == 1) // one of three times
                {
                    var dict = GenerateGenres();
                    int randomedGenre = rnd.Next(0, dict.Count);
                    this.CharacterStats.IncreaseBy(Stats.StatsNames.Social, socialGain);
                    sb.AppendLine("You`ve met a cool hipster girl. ");
                    sb.AppendFormat("She told you about new music genre - {0}. {1} ", dict.ElementAt(randomedGenre).Key, dict.ElementAt(randomedGenre).Value);
                    sb.AppendFormat("\nSocial skills increased by {0}.\n", socialGain);
                }
                sb.AppendFormat("Health increased by {0}.\n", healthGain);
                sb.AppendFormat("Current Mood increased by {0}.", moodGain);
                MessageBox.Show(sb.ToString(), "Worth it!");
            }
            else MessageBox.Show("Not enough money.", "WTF?");
        }

        // add functions to do something(listen to music etc)

    }

    
   
   
}
