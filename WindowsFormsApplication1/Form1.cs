using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int[] numbers;

        public Form1()
        {
            numbers = new int[4];
            InitializeComponent();
            numberGenerator();
        }

        private void submitResult(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)Keys.Enter)
            {
                e.Handled = true;

                string text = resultTxt.Text;
                int result = 0;
                
                try
                {
                    result = Convert.ToInt32(text);
                    resultTxt.BackColor = Color.White;
                }
                catch (Exception exp)
                {
                    resultTxt.BackColor = Color.Red;
                }

                if (numbers[3] == result)
                {
                    resultTxt.Text = "";
                    resultTxt.BackColor = Color.White;
                    numberGenerator();
                }
                else
                {
                    resultTxt.BackColor = Color.Yellow;
                }

            }
        }

        private void numberGenerator()
        {
            Random generator = new Random();

            numbers[3] = generator.Next(4);
            switch (numbers[3])
            {
                case 0:     // Addition
                    numbers[0] = generator.Next(1000);
                    numbers[1] = generator.Next(1000);
                    numbers[3] = numbers[0] + numbers[1];
                    equation.Text = numbers[0].ToString() + " + " + numbers[1].ToString();
                    break;

                case 1:     // Subtraction
                    numbers[0] = generator.Next(1000);
                    numbers[1] = generator.Next(1000);
                    numbers[3] = numbers[0] - numbers[1];
                    equation.Text = numbers[0].ToString() + " - " + numbers[1].ToString();
                    break;

                case 2:     // Multiplication
                    numbers[0] = generator.Next(33);
                    numbers[1] = generator.Next(33);
                    numbers[3] = numbers[0] * numbers[1];
                    equation.Text = numbers[0].ToString() + " * " + numbers[1].ToString();
                    break;

                case 3:     // Division
                    numbers[0] = generator.Next(1000);
                    numbers[1] = generator.Next(100);
                    while (numbers[0] % numbers[1] != 0)
                    {
                        numbers[0] = generator.Next(1000);
                        numbers[1] = generator.Next(2, 100);
                    }
                    numbers[3] = numbers[0] / numbers[1];


                    equation.Text = numbers[0].ToString() + " / " + numbers[1].ToString();
                    break;
            }
        }
    }
}
