using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Paralel_Graph
{
    public partial class Form1 : Form
    {
        public static double e1 = 0.01;
        public PlotModel PlotModel1 { get; set; }
        public PlotModel PlotModel2 { get; set; }

        // Делегат для передачі необхідного методу (g1 та g2) до методу calc()
        public delegate double MyFunc(double x);

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            PlotModel1 = new PlotModel { Title = "Function 1 Calculation" };
            PlotModel2 = new PlotModel { Title = "Function 2 Calculation" };

            // Створюємо перший потік
            Thread thread1 = new Thread(ThreadFunction1);
            thread1.Start();
            // Створюємо другий потік
            Thread thread2 = new Thread(ThreadFunction2);
            thread2.Start();
        }

        private void button_e_Click(object sender, EventArgs e)
        {
            try
            {
                e1 = Double.Parse(textBox_e.Text);
            }
            catch
            {
                MessageBox.Show("Failed to parse e");
            }
        }

        private void button_x1_Click(object sender, EventArgs e)
        {
            try
            {
                x1 = Double.Parse(textBox_x1.Text);
            }
            catch
            {
                MessageBox.Show("Failed to parse x1");
            }
        }

        private void button_x2_Click(object sender, EventArgs e)
        {
            try
            {
                x2 = Double.Parse(textBox_x2.Text);
            }
            catch
            {
                MessageBox.Show("Failed to parse x2");
            }
        }

        // Реалізація функції f(x) = 2x - cos (x)
        public static double g1(double x)
        {
            double y = 0.5 * Math.Cos(x);
            return y;
        }
        // Реалізація функції f(x) = x + ln x
        public static double g2(double x)
        {
            double y = (2 * x - Math.Log(x)) / 3;
            return y;
        }
        // Основний метод з розрахунками
        public static double calc(double x, MyFunc g)
        {
            double temp, d;
            do
            {
                temp = g(x);
                d = Math.Abs(temp - x);
                x = temp;
                //Console.WriteLine (x);
            }
            while (d >= e1);
            return (x);
        }

        public static double x1 = 0.5;

        // Організація потоків для функцій
        void ThreadFunction1()
        {
            MyFunc g = g1;
            x1 = calc(x1, g);
            // Plot graph
            PlotModel1.Series.Add(new FunctionSeries(g1, 0, x1, 0.1, "Function 1"));
            plotView1.Model = PlotModel1;
            // Update result label
            labelAnswer1.Invoke(new Action(() =>
            {
                labelAnswer1.Text = $"Answer: X = {x1}, equals {e1}";
            }));
        }

        public static double x2 = 0.75;

        void ThreadFunction2()
        {
            MyFunc g = g2;
            x2 = calc(x2, g);
            // Plot graph
            PlotModel2.Series.Add(new FunctionSeries(g2, 0, x2, 0.1, "Function 2"));
            plotView2.Model = PlotModel2;
            // Update result label
            labelAnswer2.Invoke(new Action(() =>
            {
                labelAnswer2.Text = $"Answer: X = {x2}, equals {e1}";
            }));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
