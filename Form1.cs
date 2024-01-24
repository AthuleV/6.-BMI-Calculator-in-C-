using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.BMI_Calculator_in_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Get the height and weight from user input
            if (double.TryParse(textBox1.Text, out double height) && height > 0 &&
                double.TryParse(textBox2.Text, out double weight) && weight > 0)
            {
                // Calculate BMI using the formula: BMI = weight / (height * height)
                double bmi = weight / Math.Pow(height, 2);

                // Display the result
                textBox3.Text = bmi.ToString("F2");

                // Provide a basic interpretation of the BMI value
                string interpretation = GetBMIInterpretation(bmi);
                textBox4.Text = interpretation;
            }
            else
            {
                // Display an error message if the input is invalid
                MessageBox.Show("Invalid input. Please enter positive numbers for height and weight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetBMIInterpretation(double bmi)
        {
            // Provide a basic interpretation of the BMI value
            if (bmi < 18.5)
            {
                return "You are underweight";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                return "You are normal";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                return "You are overweight";
            }
            else
            {
                return "You are obese";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
