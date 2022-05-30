using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaneeCalculator
{
    public partial class MainWindow : Form
    {
        Double resultNumber = 0;
        String operation = "";
        bool isOperation = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || (isOperation))
            {
                Result.Clear();
            }
            isOperation = false;
            Button button = (Button)sender;
            Result.Text = Result.Text + button.Text;
        Problem.Text = Problem.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            resultNumber = Double.Parse(Result.Text);
            isOperation = true;
            Problem.Text = resultNumber + " " + operation;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            Problem.Text = "";
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    Result.Text=(resultNumber + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (resultNumber - Double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (resultNumber * Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (resultNumber / Double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
        private About aboutForm;
        private void about_click(object sender, EventArgs e)
        {
            aboutForm = new About();
            aboutForm.Show();
        }
    }
}
