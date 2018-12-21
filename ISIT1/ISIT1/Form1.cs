using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISIT1;

namespace ISIT1
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> dictionaryOfCriteria = new Dictionary<string, int>(6);

        public Form1()
        {
            InitializeComponent();

            dictionaryOfCriteria.Add("labelFrontend", 0);
            dictionaryOfCriteria.Add("labelBackend", 0);
            dictionaryOfCriteria.Add("labelStrongTyping", 0);
            dictionaryOfCriteria.Add("labelPopularity", 0);
            dictionaryOfCriteria.Add("labelWorkWithForms", 0);
            dictionaryOfCriteria.Add("labelEasyToTeach", 0);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            DataRepository dataRepository = DataRepository.GetInstance();
            ExpertSystem expertSystem = ExpertSystem.GetExpertSystem();
            string appropriateWebTechnology = expertSystem.FindAppropriateWebTechnology(dictionaryOfCriteria, dataRepository.GetAnswers());
            MessageBox.Show(appropriateWebTechnology);
        }          

        private void barBackend_ValueChanged(object sender, EventArgs e)
        {
            labelBackend.Text = Convert.ToString(barBackend.Value);
            dictionaryOfCriteria[labelBackend.Name] = barBackend.Value;
        }

        private void barFrontend_ValueChanged(object sender, EventArgs e)
        {
            labelFrontend.Text = Convert.ToString(barFrontend.Value);
            dictionaryOfCriteria[labelFrontend.Name] = barFrontend.Value;
        }

        private void barStrongTyping_ValueChanged(object sender, EventArgs e)
        {
            labelStrongTyping.Text = Convert.ToString(barStrongTyping.Value);
            dictionaryOfCriteria[labelStrongTyping.Name] = barStrongTyping.Value;
        }

        private void barPopularity_ValueChanged(object sender, EventArgs e)
        {
            labelPopularity.Text = Convert.ToString(barPopularity.Value);
            dictionaryOfCriteria[labelPopularity.Name] = barPopularity.Value;        
        }

        private void barWorkWithForms_ValueChanged(object sender, EventArgs e)
        {
            labelWorkWithForms.Text = Convert.ToString(barWorkWithForms.Value);
            dictionaryOfCriteria[labelWorkWithForms.Name] = barWorkWithForms.Value;
        }

        private void barEasyToTeach_ValueChanged(object sender, EventArgs e)
        {
            labelEasyToTeach.Text = Convert.ToString(barEasyToTeach.Value);
            dictionaryOfCriteria[labelEasyToTeach.Name] = barEasyToTeach.Value;
        }
    }
}
