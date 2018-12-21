using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IsitLab3.Entities;


namespace IsitLab3
{
    public partial class Form1 : Form
    {
        private List<TableParameter> idialParameters;       
        
        public Form1()
        {
            idialParameters = new List<TableParameter>();
            InitializeComponent();
        }

        private void DownloadTable_Click(object sender, EventArgs e)
        {
            Network net = new Network();
            Network.Train(net);
            Network.Test(net);
            idialParameters = Utilities.DownloadTableFromFile();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            ResultClassLabel.Text = Convert.ToString(Utilities.ParseResultTableFromFile(Convert.ToInt32(param1.Text), Convert.ToInt32(param2.Text), Convert.ToInt32(param3.Text)));
        }
    }
}
