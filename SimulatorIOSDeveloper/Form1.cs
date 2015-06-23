using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
namespace SimulatorIOSDeveloper
{
    public partial class MainForm : Form
    {
        // to add tooltips on actions & stats
        private static Character GetObj()
        {
            Character obj = new Character();
            return obj;
        }
        public MainForm()
        {
            InitializeComponent();
            this.MoneyLabelSet.Text = MainForm.GetObj().Money + "$";
            this.StatusLabelSet.Text = MainForm.GetObj().CurrentStatus;
            this.NameLabel.Text = "what`s up, " + MainForm.GetObj().Name + "?";
            //this.DeviceListBox.DataSource = MainForm.GetObj().CurrentDevices;
            foreach (var el in MainForm.GetObj().CurrentDevices)
            {
                this.DeviceListBox.Items.Add(el.Name);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MoneyLabelSet_Click(object sender, EventArgs e)
        {

        }

        private void DeviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(this.DeviceListBox.SelectedItem.ToString());

            try
            {
                this.DNameLabelSet.Text = GetObj().CurrentDevices.First(x => x.Name == DeviceListBox.SelectedItem.ToString()).Name;
                this.DModelLabelSet.Text = GetObj().CurrentDevices.First(x => x.Name == DeviceListBox.SelectedItem.ToString()).Model;
                //this.ModelLabelSet.Text = MainForm.GetObj().CurrentDevices.Find(x => x.Name.Equals(DeviceListBox.SelectedItem.ToString()));

            }
            catch (NullReferenceException)
            {
                // dont do anything
            }
        }

        private void DevicesBox_Enter(object sender, EventArgs e)
        {

        }


    }
}
