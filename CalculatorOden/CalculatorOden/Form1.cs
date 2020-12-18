using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorOden
{
    public partial class App : Form
    {

        Double val = 0;
        String text = "";
        bool oper_press = false;

        public App()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if((output.Text == "0")||(oper_press))
            {
                output.Clear();
            }

            Button button = (Button)sender;
            output.Text = output.Text + button.Text;//Adds the value from the button to the output textbox
            oper_press = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void op_pres(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = Double.Parse(output.Text);
            oper_press = true;
        }

        private void op_res(object sender, EventArgs e)
        {
            switch(text)
            {
                case "+":
                    output.Text = (val + Double.Parse(output.Text)).ToString();//add
                    break;
                case "-":
                    output.Text = (val - Double.Parse(output.Text)).ToString();//subtract
                    break;
                case "/":
                    output.Text = (val / Double.Parse(output.Text)).ToString();//divide
                    break;
                case "x":
                    output.Text = (val * Double.Parse(output.Text)).ToString();//multiply
                    break;
                default:
                    break;
            }
            oper_press = false;
        }

        private void c_press(object sender, EventArgs e)
        {
            output.Clear();
            val = 0;
        }
    }
}
