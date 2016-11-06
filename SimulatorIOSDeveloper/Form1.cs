using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static SimulatorIOSDeveloper.Stats;

namespace SimulatorIOSDeveloper
{
    public partial class MainForm : Form
    {
        // to add tooltips on actions & stats
            Character obj = new Character();
            static int counter = 0; // count of turns
            List<String> quotes = new List<String>();
            bool firstInit = true;
        // to name properly after finishing

        PictureBox p = new PictureBox();

        // to do!!
        private void ImageTest()
        {
            Image image = Image.FromFile(@"H:\OneDrive\Visual Studio 2012\Projects\SimulatorIOSDeveloper\SimulatorIOSDeveloper\Resources\symbol_add.png");
            p.Image = image;
            //p.LoadAsync();
            p.Height = image.Height;
            p.Width = image.Width;
            p.Location = new Point(this.HealthBar.Location.X + this.HealthBar.Size.Width - this.HealthBar.Margin.Right - this.p.Width, 0);
            p.Location = new Point(this.HealthLabel.Location.X + this.HealthLabel.Size.Width, this.HealthLabel.Location.Y);
            p.BackColor = Color.Transparent;
            this.StatsBox.Controls.Add(p);
            p.BringToFront();
            

            // p.Image = Image.FromFile();

        }
        
        public MainForm()
        {
            InitializeComponent();
            InitFromObj(obj);
            this.DeviceListBox.SelectedIndex = 0;
            InitQuotes();
            SetRandomQuote();
            //this.ImageTest();
           
        }
        private void InitFromObj(Character obj)
        {
            this.MoneyLabelSet.Text = this.obj.Money + "$";
            this.StatusLabelSet.Text = this.obj.CurrentStatus;
            this.NameLabel.Text = String.Format("what`s up, {0}?", this.obj.Name);
            //this.DeviceListBox.DataSource = MainForm.obj().CurrentDevices;
            foreach (var el in this.obj.CurrentDevices)
            {
                this.DeviceListBox.Items.Add(el.Name);
            }
            this.UpdateAllStats();
            this.firstInit = false;

        }
        private void SetRandomQuote()
        {
            this.QuoteLabel.Text = quotes.Count > 0 ? quotes[this.obj.rnd.Next(0, quotes.Count)] : "Sometimes quotes aren`t worth it.";
        }
        
        private void ChangeStat(StatsNames stat, int value)
        {
            //this.PlusLabel.Text = "";
            this.PlusLabel.ForeColor = Color.Black;
            //this.MinusLabel.Text = "";
            this.MinusLabel.ForeColor = Color.Black;
            //bool plus = false;

            // some defensive programming

            Contract.Requires(value >= 0 && value <= 100, "invalid value");
            
            switch (stat)
            {
                case StatsNames.Health:
                    if (!this.firstInit)
                    {
                        if (this.HealthBar.Value < value)
                        {
                            this.PlusBox.Visible = true;
                            this.PlusLabel.Text = "health";
                            TimerFadingPlus.Start();
                        }
                        else if (this.HealthBar.Value > value)
                        {
                            this.MinusLabel.Text = "health";
                            this.MinusBox.Visible = true;
                            TimerFadingMinus.Start();
                        }

                        
                        
                       
                    }
                    this.HealthBar.Value = value;
                   
                    break;
                case StatsNames.Mood:
                    if (!this.firstInit)
                    {
                        if (this.MoodBar.Value < value)
                        {
                            this.PlusLabel.Text = "mood";
                            this.PlusBox.Visible = true;
                            TimerFadingPlus.Start();


                        }
                        else if (this.MoodBar.Value > value)
                        {
                            this.MinusLabel.Text = "mood";
                            this.MinusBox.Visible = true;
                            TimerFadingMinus.Start();

                        }



                    }
                    this.MoodBar.Value = value;
                    break;
                case StatsNames.Programming:
                    if (!this.firstInit)
                        {
                        if (this.ProgrammingBar.Value < value)
                        {
                            this.PlusBox.Visible = true;
                            this.PlusLabel.Text = "prog";
                            TimerFadingPlus.Start();
                        }
                        else if (this.ProgrammingBar.Value > value)
                        {
                            this.MinusBox.Visible = true;
                            this.MinusLabel.Text = "prog";
                            TimerFadingMinus.Start();

                        }

                    }
                    this.ProgrammingBar.Value = value;
                    break;
                case StatsNames.Social:
                    if (!this.firstInit)
                    {
                        if (this.SocialBar.Value < value)
                        {
                            this.PlusLabel.Text = "soc";
                            this.PlusBox.Visible = true;
                            TimerFadingPlus.Start();


                        }
                        else if (this.SocialBar.Value > value)
                        {
                            this.MinusLabel.Text = "soc";
                            this.MinusBox.Visible = true;
                            TimerFadingMinus.Start();

                        }

                    }
                    this.SocialBar.Value = value;
                    break;
            }


        }
        private void InitQuotes()
        {
            this.quotes.Add("Sometimes life hits you in the head with a brick. Don't lose faith.");
            this.quotes.Add("Innovation distinguishes between a leader and a follower.");
            this.quotes.Add("Be a yardstick of quality. Some people aren't used to an environment where excellence is expected.");
            this.quotes.Add("Design is not just what it looks like and feels like. Design is how it works.");
            this.quotes.Add("I want to put a ding in the universe.");
            this.quotes.Add("Quality is much better than quantity. One home run is much better than two doubles.");
            this.quotes.Add("Don’t let the noise of other’s’ opinions drown out your own inner voice.");
            this.quotes.Add("Stay hungry. Stay foolish.");
           
            
        }


        public void UpdateCounter()
        {
            counter++;
            this.TurnsCountValue.Text = Convert.ToString(counter);
        }
        public void UpdateMoney()
        {
            this.MoneyLabelSet.Text = obj.Money + "$";

        }
        public void UpdateAllStats()
        {
            this.ChangeStat(StatsNames.Social, obj.CharacterStats.SocialValue);
            this.ChangeStat(StatsNames.Health, obj.CharacterStats.HealthValue);
            this.ChangeStat(StatsNames.Mood, obj.CharacterStats.MoodValue);
            this.ChangeStat(StatsNames.Programming, obj.CharacterStats.ProgrammingValue);
        }
        private void DeviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(this.DeviceListBox.SelectedItem.ToString());

            try
            {
                this.DNameLabelSet.Text = this.obj.CurrentDevices.First(x => x.Name == DeviceListBox.SelectedItem.ToString()).Name;
                this.DModelLabelSet.Text = this.obj.CurrentDevices.First(x => x.Name == DeviceListBox.SelectedItem.ToString()).Model;
                this.DYearLabelSet.Text = this.obj.CurrentDevices.First(x => x.Name == DeviceListBox.SelectedItem.ToString()).Year.ToString();
                //this.ModelLabelSet.Text = MainForm.obj().CurrentDevices.Find(x => x.Name.Equals(DeviceListBox.SelectedItem.ToString()));

            }
            catch (NullReferenceException)
            {
                return;
                // dont do anything
            }
        }

        private void AppleLogoBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/r/MacSucks/comments/28docp/25_year_former_mac_user_says_apple_sucks_and_why/");
        }

        private void MusicPanel_Click(object sender, EventArgs e)
        {
            // to do
            //this. 
            this.obj.ListenMusic();
            this.ChangeStat(StatsNames.Mood, obj.CharacterStats.MoodValue);
            this.UpdateCounter();
        }

        private void SwiftPanel_Click(object sender, EventArgs e)
        {
            // to do
            obj.ToCodeSwift();
            this.UpdateAllStats();
            this.UpdateMoney();
            this.UpdateCounter();

        }

        private void SmootheyPanel_Click(object sender, EventArgs e)
        {
            // to do
            this.obj.ToDrinkSmoothie();
            this.ChangeStat(StatsNames.Health, obj.CharacterStats.HealthValue);
            this.ChangeStat(StatsNames.Social, obj.CharacterStats.SocialValue);
            this.ChangeStat(StatsNames.Mood, obj.CharacterStats.MoodValue);
            this.UpdateMoney();
            this.UpdateCounter();

        }

        private void YoutubePanel_Click(object sender, EventArgs e)
        {


            this.UpdateCounter();

            // to do
        }

        private void FreelancePanel_Click(object sender, EventArgs e)
        {
            obj.ToFreelance();
            this.MoneyLabelSet.Text = obj.Money + "$";
            this.ProgrammingBar.Value = obj.CharacterStats.ProgrammingValue;
            this.SocialBar.Value = obj.CharacterStats.SocialValue;
            this.UpdateCounter();

        }

        private void SafariPanel_Click(object sender, EventArgs e)
        {
            // to do
            this.UpdateCounter();

        }

        private void ShopPanel_Click(object sender, EventArgs e)
        {
            ShopForm sf = new ShopForm() { Visible = true };
            // to do
        }

        private void BikePanel_Click(object sender, EventArgs e)
        {
            this.UpdateCounter();

            // to do mini game with graphics?
        }

        private void AppleLogoBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void QuotePicture_Click(object sender, EventArgs e)
        {
            SetRandomQuote();
        }

        // only works for black color
        private void TimerFading_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 15;
            this.PlusLabel.ForeColor = Color.FromArgb(PlusLabel.ForeColor.R + fadingSpeed, PlusLabel.ForeColor.G + fadingSpeed, this.PlusLabel.ForeColor.B + fadingSpeed);

            if (PlusLabel.ForeColor.R >= this.BackColor.R)
            {
                this.TimerFadingPlus.Stop();
                PlusLabel.ForeColor = this.BackColor;
                this.PlusLabel.Text = "";
            }
            
        }

        private void TimerFadingMinus_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 15;
            this.MinusLabel.ForeColor = Color.FromArgb(MinusLabel.ForeColor.R + fadingSpeed, MinusLabel.ForeColor.G + fadingSpeed, this.MinusLabel.ForeColor.B + fadingSpeed);

            if (MinusLabel.ForeColor.R >= this.BackColor.R)
            {
                this.TimerFadingMinus.Stop();
                MinusLabel.ForeColor = this.BackColor;
                this.MinusLabel.Text = "";
            }
        }

        // onlick create textbox where you enter your name;
        // enter - confirm & close text box
        // esc - cancel & leave the name as it was before
    }
}
