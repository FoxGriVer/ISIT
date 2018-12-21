using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BirdAndCars.Entities;

namespace BirdAndCars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CountDistanceButton_Click(object sender, EventArgs e)
        {            
            DistanceCounter counter = new DistanceCounter(new Car(double.Parse(Car1SpeedBox.Text)),
                new Car(double.Parse(Car2SpeedBox.Text)), new Bird(double.Parse(BirdSpeedBox.Text)),
                double.Parse(DistanceBox.Text));
            counter.CountDistance();

            ResultBirdDistanceLabel.Text = Convert.ToString(Math.Round(counter.TotalDistanceBird, 3));
            ResultBirdDistanceLabel.Visible = true;
            textBoxForResultDistance.Visible = true;
        }
        
    }
}
