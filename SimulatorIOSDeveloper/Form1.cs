﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
namespace SimulatorIOSDeveloper
{
    public partial class MainForm : Form
    {
        // to add tooltips on actions & stats
            Character obj = new Character();
            static int counter = 0;
            

        private List<String> quotes = new List<String>(); // to do
        public MainForm()
        {
            InitializeComponent();
            this.MoneyLabelSet.Text = this.obj.Money + "$";
            this.StatusLabelSet.Text = this.obj.CurrentStatus;
            this.NameLabel.Text = String.Format("what`s up, {0}?", this.obj.Name);
            //this.DeviceListBox.DataSource = MainForm.obj().CurrentDevices;
            foreach (var el in this.obj.CurrentDevices)
            {
                this.DeviceListBox.Items.Add(el.Name);
            }
            this.SocialBar.Value = this.obj.CharacterStats.SocialValue;
            this.HealthBar.Value = this.obj.CharacterStats.HealthValue;
            this.ProgrammingBar.Value = this.obj.CharacterStats.ProgrammingValue;
            this.MoodBar.Value = this.obj.CharacterStats.MoodValue;
            
            this.DeviceListBox.SelectedIndex = 0;
            
        }





        public void UpdateCounter()
        {
            counter++;
            this.TurnsCountValue.Text = Convert.ToString(counter);
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
            this.UpdateCounter();
        }

        private void SwiftPanel_Click(object sender, EventArgs e)
        {
            // to do
            this.UpdateCounter();

        }

        private void SmootheyPanel_Click(object sender, EventArgs e)
        {
            // to do
            this.obj.ToDrinkSmoothie();
            this.HealthBar.Value = this.obj.CharacterStats.HealthValue;
            this.SocialBar.Value = this.obj.CharacterStats.SocialValue;
            this.MoneyLabelSet.Text = obj.Money + "$";
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

            // to do
        }

        private void AppleLogoBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
