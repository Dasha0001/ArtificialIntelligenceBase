using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnealingMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x, x1, y, y1;
        List<List<NumericUpDown>> MatrixNodes = new List<List<NumericUpDown>>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericNodes_ValueChanged(object sender, EventArgs e)
        {
            x = 400; //start of matrix elements
            y = 500;
            Random random = new Random();
            y1 = y;

            for (int i = 0; i < MatrixNodes.Count(); i++) //clean matrix
                for (int j = 0; j < MatrixNodes[i].Count(); j++)
                    this.Controls.Remove(MatrixNodes[i][j]);
            MatrixNodes.Clear();

            for (int i = 1; i < numericNodes.Value; i++)
            {
                x1 = x;
                MatrixNodes.Add(new List<NumericUpDown>());
                for (int j = 0; j < numericNodes.Value - 1; j++)
                {
                    if (i > j)
                    {
                        MatrixNodes[i - 1].Add(new NumericUpDown());
                        MatrixNodes[i - 1].Add(new NumericUpDown());
                        MatrixNodes[i - 1][j].Size = new Size(37, 20);
                        MatrixNodes[i - 1][j].Location = new Point(y1, x1);
                        MatrixNodes[i - 1][j].Minimum = random.Next(1, 100);
                        Controls.Add(MatrixNodes[i - 1][j]);
                        x1 -= 20;
                    }
                }
                y1 -= 30;

            }

        
       

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
