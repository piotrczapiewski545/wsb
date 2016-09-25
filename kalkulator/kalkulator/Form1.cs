using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        Double liczba1 = 0.0, liczba2 = 0.0, wynik = 0.0;
        String equation;
        Boolean wyczyść = true;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = wynik.ToString();
        }

        private double konwertuj(String s){
            double w=0.0;
            try
            {
                w=Double.Parse(s);
            }
            catch (Exception e)
            {
                equation = "";
            }
            return w;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (wyczyść) ? "1" : textBox1.Text+"1";
            wyczyść = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (wyczyść) ? "2" : textBox1.Text + "2";
            wyczyść = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (wyczyść) ? "3" : textBox1.Text + "3";
            wyczyść = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = (wyczyść) ? "4" : textBox1.Text + "4";
            wyczyść = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = (wyczyść) ? "5" : textBox1.Text + "5";
            wyczyść = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = (wyczyść) ? "6" : textBox1.Text + "6";
            wyczyść = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = (wyczyść) ? "7" : textBox1.Text + "7";
            wyczyść = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = (wyczyść) ? "8" : textBox1.Text + "8";
            wyczyść = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = (wyczyść) ? "9" : textBox1.Text + "9";
            wyczyść = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (wyczyść || "0".Equals(textBox1.Text)) textBox1.Text = "0";
            else textBox1.Text += "0";
            wyczyść = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (wyczyść || "0".Equals(textBox1.Text)) textBox1.Text = "0.";
            else if (!textBox1.Text.Contains(".")) textBox1.Text += ".";
            wyczyść = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ("+".Equals(equation))
            {
                liczba2 = konwertuj(textBox1.Text);
                oblicz("+");
                equation = "+";
                liczba1 = konwertuj(textBox1.Text);
            }
            else
            {
                liczba1 = konwertuj(textBox1.Text);
                equation = "+";
                textBox1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            liczba2 = konwertuj(textBox1.Text);
            oblicz(equation);
        }

        private void oblicz(string e)
        {
            switch (e)
            {
                case "+":
                    textBox1.Text = (liczba1 + liczba2).ToString();
                    equation = "";
                    break;
                case "-":
                    textBox1.Text = (liczba1 - liczba2).ToString();
                    equation = "";
                    break;
                case "*":
                    textBox1.Text = (liczba1 * liczba2).ToString();
                    equation = "";
                    break;
                case "/":
                    if (liczba2 != 0)
                    {
                        textBox1.Text = (liczba1 / liczba2).ToString();
                    }
                    equation = "";
                    break;
                case "":
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if ("-".Equals(equation))
            {
                liczba2 = konwertuj(textBox1.Text);
                oblicz("-");
                equation = "-";
                liczba1 = konwertuj(textBox1.Text);
            }
            else
            {
                liczba1 = konwertuj(textBox1.Text);
                equation = "-";
                textBox1.Text = "";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if ("*".Equals(equation))
            {
                liczba2 = konwertuj(textBox1.Text);
                oblicz("*");
                equation = "*";
                liczba1 = konwertuj(textBox1.Text);
            }
            else
            {
                liczba1 = konwertuj(textBox1.Text);
                equation = "*";
                textBox1.Text = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if ("/".Equals(equation))
            {
                liczba2 = konwertuj(textBox1.Text);
                oblicz("/");
                equation = "/";
                liczba1 = konwertuj(textBox1.Text);
            }
            else
            {
                liczba1 = konwertuj(textBox1.Text);
                equation = "/";
                textBox1.Text = "";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1) textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            else
            {
                textBox1.Text = "0";
                wyczyść = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            wyczyść = true;
            equation = "";
        }
    }
}
