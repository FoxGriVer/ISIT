using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeneticAlgorithmLab
{
    public partial class MainForm : Form
    {
        public string textBoxLogText
        {
            get { return textBoxLog.Text; }
            set { textBoxLog.Text = value; }
        }

        Population myPopulation;

        int indCount = 8;
        int indLifeTime = 15;
        double crossbreedValue = 0.75;
        double mutationValue = 0.5;
        double mutationMax = 0.05;
        double sameGeneDiv = 0.005;
        int generationNumber = 1000;

        double crossoverValue = 0.5;

        double selectionValue = 4.0;

        public MainForm()
        {
            InitializeComponent();

            Util.SaveForm(this);
            Util.pointList = new List<KeyValuePair<double, double>>();

            textBoxPoints.Text = Util.textBoxPointsDefault;

            textBoxIndCount.Text = indCount.ToString();
            textBoxGenerationNumber.Text = generationNumber.ToString();
            textBoxSelectionVal.Enabled = true;
            textBoxSelectionVal.Text = selectionValue.ToString();
        }

       
        private void buttonStartGA_Click(object sender, EventArgs e)
        {            
            ReadGAValues();

            myPopulation = new Population(indCount, 2, indLifeTime, crossbreedValue, mutationValue, mutationMax, 1.0, sameGeneDiv, generationNumber);
                      
            myPopulation.InitBLXCrossover(crossoverValue);

            selectionValue = double.Parse(textBoxSelectionVal.Text);
            myPopulation.InitTournamentSelection((int)(selectionValue));
           

            bool errFlag = false;
            var pointListTemp = Util.ReadPoints(textBoxPoints.Text, out errFlag);
            Util.pointList = new List<KeyValuePair<double, double>>(pointListTemp);
        }

        private void buttonStartGA_Click_1(object sender, EventArgs e)
        {
            myPopulation.Do();
        }

        public void ReadGAValues()
        {
            indCount = int.Parse(textBoxIndCount.Text); 
            generationNumber = int.Parse(textBoxGenerationNumber.Text);
        }        
    }
}
