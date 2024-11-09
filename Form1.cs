using System;
using System.Windows.Forms;

namespace BarChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Titles.Add("Pie Chart");
            chart1.Series["s1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
        private void updateChartButton_Click(object sender, EventArgs e)
        {
            int value1, value2, value3;

            string label1 = textBox1.Text;
            string label2 = textBox2.Text;
            string label3 = textBox3.Text;

            if (int.TryParse(textBox1.Text, out value1) &&
                int.TryParse(textBox2.Text, out value2) &&
                int.TryParse(textBox3.Text, out value3))
            {
                chart1.Series["s1"].Points.Clear();
                chart1.Series["s1"].Points.AddXY(label1, value1);
                chart1.Series["s1"].Points.AddXY(label2, value2);
                chart1.Series["s1"].Points.AddXY(label3, value3);
            }
            else
            {
                MessageBox.Show("Please enter valid number values for all fields.");
            }
        }
    }
}
