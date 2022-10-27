using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmb_Options.Text == "Celsius to Fahrenheit")
            {
                double Result = Convert.ToDouble(label1.Text);
                labelResult.Text = CelsiusToFahrenheit(Result);
            }
            else if(cmb_Options.Text == "Fahrenheit To Celsius")
            {
                double Result = Convert.ToDouble(label1.Text);
                labelResult.Text = FahreheitToCelsius(Result);
            }
        }
        private string CelsiusToFahrenheit(double Temperature)
        {
            double Result = (Temperature * 9 / 5) + 32;
            return Result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string FahreheitToCelsius(double Temperature)
        {
            double Result = (Temperature - 32) * 5 / 9;
            return Result.ToString();
        }
    }
}
